import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

import { HeaderComponent } from './components/header/header.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { FooterComponent } from './components/footer/footer.component';
import { AuctionsTableComponent } from './components/table/auctions/auctions.component';

// filter components
import { ArrayDropdownComponent } from './components/dropdowns/array/array.component';
import { ObjectDropdownComponent } from './components/dropdowns/object/object.component';
import { SearchComponent } from './components/search/search.component';
import { LoadingComponent } from './components/loading/loading.component';

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    FormsModule,
    NgxDatatableModule
  ],
  exports: [
    HeaderComponent,
    NavbarComponent,
    FooterComponent,
    AuctionsTableComponent,
    SearchComponent,
    ArrayDropdownComponent,
    ObjectDropdownComponent,
    FormsModule,
    LoadingComponent
  ],
  declarations: [
    HeaderComponent,
    NavbarComponent,
    FooterComponent,
    AuctionsTableComponent,
    SearchComponent,
    ArrayDropdownComponent,
    ObjectDropdownComponent,
    LoadingComponent
  ],
  providers: [

  ]
})
export class SharedModule { }
