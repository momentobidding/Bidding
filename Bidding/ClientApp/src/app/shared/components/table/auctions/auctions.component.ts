import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { AuctionModel } from 'src/app/auctions/models/list/auction.model';
import { Page } from 'src/app/shared/models/page';

@Component({
  selector: 'app-auctions-table',
  templateUrl: './auctions.component.html',
  styleUrls: ['./auctions.component.scss']
})
export class AuctionsTableComponent implements OnInit {
  @Input() list: AuctionModel[];
  @Input() numberRows: number;
  @Input() selected: any[];

  @Output() pageChange = new EventEmitter<number>();
  @Output() sortChange = new EventEmitter<boolean>();
  @Output() rowChange = new EventEmitter<number>();

  page = new Page();

  private items = [
    { name: '5 per page', value: 5 },
    { name: '10 per page', value: 10 },
    { name: '25 per page', value: 25 },
    { name: '50 per page', value: 50 },
    { name: '100 per page', value: 100 },
    { name: 'All', value: 0 }
  ];

  constructor() { }

  ngOnInit() {
    console.log('list', this.list);
    this.page.pageNumber = 0;
    this.page.totalElements = this.list.length;
    this.page.size = 30;
  }

  onPageChange(page) {
    this.pageChange.emit(page);
  }

  onRowChange(row) {
    this.rowChange.emit(row);
  }

  onSortChange(event) {
    this.sortChange.emit(event);
  }
}
