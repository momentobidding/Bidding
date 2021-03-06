// angular
import {
  Component,
  OnInit,
  Input,
  SimpleChanges,
  EventEmitter,
  Output,
  OnChanges,
  OnDestroy,
} from "@angular/core";

// 3rd lib
import { Subscription } from "rxjs";

// internal
import { AuctionsService } from "../../services/auctions.service";
import { AuctionListRequestModel } from "../../models/list/auction-list-request.model";
import { AuctionListResponseModel } from "../../models/list/auction-list-response.model";
import { NotificationsService } from "ClientApp/src/app/core/services/notifications/notifications.service";
import { AuthService } from "ClientApp/src/app/core/services/auth/auth.service";
import {
  AuctionTopCategoryNames,
  AuctionTopCategoryIds,
} from "ClientApp/src/app/core/constants/auction-top-category-constants";
import { AuctionListItemModel } from "../../models/list/auction-list-item.model";

@Component({
  selector: "app-auction-list",
  templateUrl: "./list.component.html",
})
export class AuctionListComponent implements OnInit, OnChanges, OnDestroy {
  @Input() specifiedSearchText: string;
  @Input() selectedCategoryIds?: number[];
  @Input() selectedTypeIds?: number[];
  @Input() categoryFilter?: string;

  /** Based on this flag list loads all active and inactive auctions */
  @Input() loadAllAuctionsFlag: boolean;

  /** Show or hide select all checkbox column in auction table. */
  @Input() showSelectAllCheckboxColumn?: boolean;
  @Output() selectedChange = new EventEmitter<AuctionListItemModel[]>();

  listSubscription: Subscription;

  // API
  auctionTable: AuctionListResponseModel;
  auctionListRequest: AuctionListRequestModel;
  loggedInUserId: number;

  // pagination || form
  numberRows: number = 15;
  currentPage: number = 1;
  isLoading: boolean = true;
  selected: AuctionListItemModel[] = [];

  constructor(
    private auctionService: AuctionsService,
    private notificationService: NotificationsService,
    private authService: AuthService
  ) {
    if (this.authService.userDetails) {
      this.loggedInUserId = this.authService.userDetails.UserId;
    }
  }

  ngOnChanges(changes: SimpleChanges): void {
    const searchTextChange = changes["specifiedSearchText"];

    if (searchTextChange && !searchTextChange.isFirstChange()) {
      this.auctionListRequest.searchValue = searchTextChange.currentValue;

      this.loadActiveAuctions();
    }

    return;
  }

  ngOnInit(): void {
    this.setupInitialAuctionRequest();
    this.loadActiveAuctions();
  }

  onSortChange(event): void {}

  onSelectedChange(selected: AuctionListItemModel[]): void {
    this.selectedChange.emit(selected);
  }

  /**
   * Called on page change in auction list
   * @param pageNumber
   */
  onPageChange(pageNumber: number): void {
    // this.selectedUsers = []; TODO: kke: for admin page auction list this needs to be implemented!
    this.auctionListRequest.currentPage = pageNumber;
    this.loadActiveAuctions();
  }

  loadActiveAuctions(): void {
    this.loadAllAuctionsFlag
      ? this.getAllAuctions()
      : this.getOnlyActiveAuctions();
  }

  ngOnDestroy(): void {
    if (this.listSubscription) {
      this.listSubscription.unsubscribe();
    }
  }

  private setupInitialAuctionRequest(): void {
    this.auctionListRequest = {
      offsetStart: 0,
      offsetEnd: this.numberRows,
      currentPage: this.currentPage,
      sortByColumn: "AuctionName", // by default sort by auction name
      sortingDirection: "asc", // by default ascending
      searchValue: "",
    };
  }

  private handleCardLinkClick(filterParam: string) {
    if (filterParam === AuctionTopCategoryNames.VehicleCategoryName) {
      this.setupCardAuctionRequest();

      this.auctionListRequest.topCategoryIds = [
        AuctionTopCategoryIds.VehicleCategoryId,
      ];
    }

    if (filterParam === AuctionTopCategoryNames.PropertyCategoryName) {
      this.setupCardAuctionRequest();

      this.auctionListRequest.topCategoryIds = [
        AuctionTopCategoryIds.PropertyCategoryId,
      ];
    }

    if (filterParam === AuctionTopCategoryNames.ItemCategoryName) {
      this.setupCardAuctionRequest();

      this.auctionListRequest.topCategoryIds = [
        AuctionTopCategoryIds.ItemCategoryId,
      ];
    }

    this.loadActiveAuctions();
  }

  private setupCardAuctionRequest(): void {
    this.auctionListRequest = {
      offsetStart: 0,
      offsetEnd: this.numberRows,
      currentPage: this.currentPage,
      sortByColumn: "AuctionName",
      sortingDirection: "asc",
      searchValue: "",
    };
  }

  private getOnlyActiveAuctions() {
    this.listSubscription = this.auctionService
      .getActiveAuctions$(this.auctionListRequest)
      .subscribe(
        (response: AuctionListResponseModel) => {
          this.auctionTable = response;
          this.isLoading = false;
        },
        (error: string) => this.notificationService.error(error)
      );
  }

  private getAllAuctions() {
    this.listSubscription = this.auctionService
      .getAllAuctions$(this.auctionListRequest)
      .subscribe(
        (response: AuctionListResponseModel) => {
          this.auctionTable = response;
          this.isLoading = false;
        },
        (error: string) => this.notificationService.error(error)
      );
  }
}
