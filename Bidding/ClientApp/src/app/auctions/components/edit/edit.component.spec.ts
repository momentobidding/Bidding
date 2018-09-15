import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AuctionEditComponent } from './edit.component';

describe('FeaturesEditComponent', () => {
  let component: AuctionEditComponent;
  let fixture: ComponentFixture<AuctionEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [AuctionEditComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AuctionEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component)
      .toBeTruthy();
  });
});
