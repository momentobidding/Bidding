// Angular
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

// 3rd lib
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { AccordionModule } from 'ngx-bootstrap/accordion';
import { library } from '@fortawesome/fontawesome-svg-core';
import {
  faSearch
} from '@fortawesome/free-solid-svg-icons';

import {
  faHeart
} from '@fortawesome/free-regular-svg-icons';

// note: kke: for brand icons!
// import {
//   faMicrosoft,
//   faGoogle
// } from '@fortawesome/free-brands-svg-icons';

// Components
import { NavbarComponent } from './components/navbar/navbar.component';
import { FooterComponent } from './components/footer/footer.component';
import { CallbackComponent } from './components/callback/callback.component';
import { HeaderComponent } from './components/header/header.component';
import { GdprRulesComponent } from './components/footer/static-components/gdpr-rules/gdpr-rules.component';
import { PartnerRulesComponent } from './components/footer/static-components/partner-rules/partner-rules.component';
import { RulesListComponent } from './components/footer/static-components/rules-list/rules-list.component';
import { ServiceRulesComponent } from './components/footer/static-components/service-rules/service-rules.component';
import { FAQPageComponent } from './components/footer/static-components/faq-page/faq-page.component';


@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    FontAwesomeModule,
    AccordionModule
  ],
  exports: [
    HeaderComponent,
    NavbarComponent,
    FooterComponent,
    GdprRulesComponent,
    PartnerRulesComponent,
    RulesListComponent,
    ServiceRulesComponent,
    FAQPageComponent,
    CallbackComponent,
    FontAwesomeModule
  ],
  declarations: [
    HeaderComponent,
    NavbarComponent,
    FooterComponent,
    GdprRulesComponent,
    PartnerRulesComponent,
    RulesListComponent,
    ServiceRulesComponent,
    FAQPageComponent,
    CallbackComponent
  ]
})
export class MinSharedModule {
  constructor() {
    library.add(
      faSearch,
      faHeart
    );
  }
}
