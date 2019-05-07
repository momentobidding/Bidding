// angular
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

// Modules
import { HomeRoutingModule } from './home-routing.module';
import { SharedModule } from '../shared/shared.module';

// Components
import { ComingSoonListComponent } from './containers/coming-soon-list/list.component';
import { ComingSoonSurveyComponent } from './components/coming-soon/survey/survey.component';
import { WelcomeHeaderComponent } from './components/welcome-header/welcome-header.component';
import { SubscribeEmailComponent } from './components/coming-soon/subscribe/email/email.component';
import { SubscribeWhatsappComponent } from './components/coming-soon/subscribe/whatsapp/whatsapp.component';

// Services
import { HomeService } from './services/home.service';


@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    HomeRoutingModule
  ],
  exports: [],
  declarations: [
    ComingSoonListComponent,
    ComingSoonSurveyComponent,
    WelcomeHeaderComponent,
    SubscribeEmailComponent,
    SubscribeWhatsappComponent
  ],
  providers: [
    HomeService
  ]
})
export class HomeModule { }
