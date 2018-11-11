import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuctionListComponent } from '../auctions/containers/list/list.component';

const routes: Routes = [
  { path: '', component: AuctionListComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
