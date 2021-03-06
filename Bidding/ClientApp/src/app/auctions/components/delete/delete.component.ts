// angular
import { Component, OnInit } from "@angular/core";
import { FormGroup, FormBuilder } from "@angular/forms";

// 3rd lib
import { BsModalRef, BsModalService } from "ngx-bootstrap/modal";

// internal
import { AuctionsService } from "../../services/auctions.service";
import { AuctionDeleteRequest } from "../../models/delete/auction-delete-request.model";
import { FormService } from "ClientApp/src/app/core/services/form/form.service";
import { NotificationsService } from "ClientApp/src/app/core/services/notifications/notifications.service";
import { AuctionListItemModel } from "../../models/list/auction-list-item.model";

@Component({
  templateUrl: "./delete.component.html"
})
export class AuctionDeleteComponent implements OnInit {
  /** Passed from parent component */
  selectedAuctions: AuctionListItemModel[];

  // form
  auctionDeleteForm: FormGroup;
  submitted = false;

  formErrors = {
    auctionId: "",
    auctionName: ""
  };

  // API
  deleteRequest: AuctionDeleteRequest;

  // convenience getter for easy access to form fields
  get f() {
    return this.auctionDeleteForm.controls;
  }

  constructor(
    public bsModalRef: BsModalRef,
    private auctionService: AuctionsService,
    private notification: NotificationsService,
    private fb: FormBuilder,
    private formService: FormService,
    private modalService: BsModalService
  ) {}

  ngOnInit(): void {
    this.buildForm();
  }

  onSubmit(): void {
    this.submitted = true;

    // mark all fields as touched
    this.formService.markFormGroupTouched(this.auctionDeleteForm);

    if (this.auctionDeleteForm.valid) {
      this.makeRequest();
    } else {
      this.formErrors = this.formService.validateForm(
        this.auctionDeleteForm,
        this.formErrors,
        false
      );
    }

    // stop here if form is invalid
    if (this.auctionDeleteForm.invalid) {
      return;
    }
  }

  private buildForm(): void {
    this.auctionDeleteForm = this.fb.group({});

    // on each value change we call the validateForm function
    // We only validate form controls that are dirty, meaning they are touched
    // the result is passed to the formErrors object
    this.auctionDeleteForm.valueChanges.subscribe(data => {
      this.formErrors = this.formService.validateForm(
        this.auctionDeleteForm,
        this.formErrors,
        true
      );
    });
  }

  private setupDeleteRequest(): void {
    this.deleteRequest = {
      auctionIds: this.selectedAuctions.map(auct => auct.auctionId)
    };
  }

  private makeRequest(): void {
    this.setupDeleteRequest();

    this.auctionService.deleteAuctions$(this.deleteRequest).subscribe(
      (data: boolean) => {
        const deleteSuccess = data;
        if (deleteSuccess) {
          this.notification.success("Auction(s) successfully deleted.");
          this.bsModalRef.hide();
          this.modalService.setDismissReason("Delete");
        } else {
          this.notification.error("Could not delete auction(s).");
        }
      },
      (error: string) => this.notification.error(error)
    );
  }
}
