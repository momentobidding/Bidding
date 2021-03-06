export interface AuctionEditRequestModel {
  auctionId: number;
  auctionName: string;
  auctionStartingPrice: number;
  auctionStartDate: Date;
  auctionApplyTillDate: Date;
  auctionEndDate: Date;
  auctionStatusId: number;
}
