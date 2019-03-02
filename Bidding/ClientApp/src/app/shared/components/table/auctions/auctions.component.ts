// angular
import { Component, OnInit, Input, EventEmitter, Output, ViewChild } from '@angular/core';

// internal
import { AuctionModel } from 'ClientApp/src/app/auctions/models/list/auction.model';


@Component({
  selector: 'app-auctions-table',
  templateUrl: './auctions.component.html',
  styleUrls: []
})
export class AuctionsTableComponent implements OnInit {
  // table
  @Input() numberRows: number;
  @Input() auctionTable: AuctionModel;
  @Input() selected: any[];

  @Output() pageChange = new EventEmitter<number>();
  @Output() sortChange = new EventEmitter<boolean>();
  @Output() detailsClick = new EventEmitter<boolean>();
  @Output() selectedChange = new EventEmitter<any>();

  @ViewChild('myTable') table: any;

  constructor() { }

  ngOnInit(): void {
  }

  onPageChange(page): void {
    this.pageChange.emit(page);
  }

  onSortChange(event): void {
    this.sortChange.emit(event);
  }

  onDetailsClick(): void {
    this.detailsClick.emit();
  }

  onSelect({ selected }): void {
    console.log('Select Event', selected, this.selected);

    this.selected.splice(0, this.selected.length);
    this.selected.push(...selected);

    console.log('selected: ', selected)
    this.selectedChange.emit(selected);
  }
}
