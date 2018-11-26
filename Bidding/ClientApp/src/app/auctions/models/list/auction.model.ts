export interface AuctionModel extends AuctionItem {
  auctions: AuctionItem[];
  currentPage: number;
  itemCount: number;
}
export interface AuctionItem {
  startDate: Date;
  endDate: Date;
  price: number;
  name: string;
  description: string;
  id: number;
  creatorFirstName: string;
  creatorLastName: string;
  creatorId: number;
}
