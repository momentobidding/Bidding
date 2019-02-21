// angular
import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';

// rxjs
import { Subscription } from 'rxjs';
import { switchMap } from 'rxjs/operators';

// internal
import { AuctionsService } from '../../services/auctions.service';
import { AuctionDetailsModel } from '../../models/details/auction-details.model';
import { NotificationsService } from 'ClientApp/src/app/core/services/notifications/notifications.service';
import { AuctionListRequest } from '../../models/list/auction-list-request.model';


@Component({
  selector: 'app-auction-details',
  templateUrl: './details.component.html',
  styleUrls: []
})
export class AuctionDetailsComponent implements OnInit, OnDestroy {
  // details
  auctionDetailsSub: Subscription;
  auctionDetails: AuctionDetailsModel;

  // utility
  loading: boolean;

  // API
  request: AuctionListRequest;

  constructor(
    private auctionApi: AuctionsService,
    private notification: NotificationsService,
    private route: ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.getAuctionDetails();
  }

  ngOnDestroy(): void {
    if (this.auctionDetailsSub) {
      this.auctionDetailsSub.unsubscribe();
    }
  }

  private getAuctionDetails(): void {
    this.auctionDetailsSub =
      this.route.paramMap.pipe(
        switchMap((params: ParamMap) =>
          this.auctionApi.getAuctionDetails$(Number(params.get('id'))))
      ).subscribe(response => { this.auctionDetails = response; },
        (error: string) => this.notification.error(error));
  }
}
