// angular modules
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

// routing
import { AppRoutingModule } from './app-routing.module';

// import { PingComponent } from './ping/ping.component';
// import { ProfileComponent } from './profile/profile.component';
// import { AdminComponent } from './admin/admin.component';

// services
import { AuthService } from './auth/auth.service';
// import { AuthGuardService } from './auth/auth-guard.service';
// import { ScopeGuardService } from './auth/scope-guard.service';

// In-house components
import { CallbackComponent } from './pages/callback/callback.component';
import { SubscribeEmailComponent } from './home/components/coming-soon/subscribe/email/email.component';
import { SubscribeWhatsappComponent } from './home/components/coming-soon/subscribe/whatsapp/whatsapp.component';
import { AppComponent } from './app.component';

// In-house Modules
import { CoreModule } from './core/core.module';
import { SharedModule } from './shared/shared.module';
import { HomeModule } from './home/home.module';
import { BlogModule } from './blog/blog.module';
import { AuctionsModule } from './auctions/auctions.module';

// 3rd party modules
import { ScrollToModule } from '@nicky-lenaers/ngx-scroll-to';
import { ModalModule } from 'ngx-bootstrap/modal';

@NgModule({
  declarations: [
    AppComponent,
    CallbackComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    ModalModule.forRoot(),
    SharedModule,
    HomeModule,
    BlogModule,
    CoreModule.forRoot(),
    ScrollToModule.forRoot(),
    AuctionsModule,
    // leave routing module as the last one!
    AppRoutingModule
  ],
  providers: [
    AuthService // ,
    // AuthGuardService,
    // ScopeGuardService
  ],
  bootstrap: [
    AppComponent
  ],
  entryComponents: [
    SubscribeEmailComponent,
    SubscribeWhatsappComponent
  ]
})
export class AppModule { }
