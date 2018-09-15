import { Component, OnInit } from '@angular/core';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { Router } from '@angular/router';
import { SubscribeEmailComponent } from '../../components/coming-soon/subscribe/email/email.component';
import { SubscribeWhatsappComponent } from '../../components/coming-soon/subscribe/whatsapp/whatsapp.component';

@Component({
  selector: 'app-coming-soon-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ComingSoonListComponent implements OnInit {
  public bsModalRef: BsModalRef;

  constructor(private modalService: BsModalService, public router: Router) { }

  public ngOnInit() {
  }

  // Modals
  public openEmail() {
    const initialState = {
      // featureId: this.selected[0].FeatureId,
      // featureName: this.selected[0].FeatureName,
      // featureValue: this.selected[0].FeatureValue,
      // licenseCode: this.licenseCode
    };

    this.bsModalRef = this.modalService.show(SubscribeEmailComponent, { initialState });
    this.bsModalRef.content.closeBtnName = 'Close';
    this.modalService.onHide.subscribe(resp => { });
  }

  public openWhatsapp() {
    const initialState = {
      // featureId: this.selected[0].FeatureId,
      // featureName: this.selected[0].FeatureName,
      // featureValue: this.selected[0].FeatureValue,
      // licenseCode: this.licenseCode
    };

    this.bsModalRef = this.modalService.show(SubscribeWhatsappComponent, { initialState });
    this.bsModalRef.content.closeBtnName = 'Close';
    this.modalService.onHide.subscribe(resp => { });
  }
}
