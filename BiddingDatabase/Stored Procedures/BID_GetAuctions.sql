﻿CREATE PROCEDURE [dbo].[BID_GetAuctions] 
--@selectedCategories BID_CategoryIdArray READONLY
--	,@selectedTypes BID_TypeIdArray READONLY
	--,
	--@startDate date,
	--@endDate date,
	@start INT
	,@end INT
	--@sortByColumn varchar(50),
	--@sortingDirection varchar(50)
AS
BEGIN
	DECLARE @categories TABLE ([CategoryId] [int] INDEX IX1 CLUSTERED);
	DECLARE @types TABLE ([TypeId] [int] INDEX IX1 CLUSTERED);

	INSERT INTO @categories (CategoryId)
	SELECT CategoryId
	FROM @categories-- @selectedCategories;

	INSERT INTO @types (TypeId)
	SELECT TypeId
	FROM @types -- @selectedTypes;

	SELECT auct.AuctionId
		,auct.Name AS AuctionName
		,auct.StartingPrice AS AuctionStartingPrice
		,auct.StartDate AS AuctionStartDate
		,auct.EndDate AS AuctionEndDate
		,asta.Name AS AuctionStatusName
	FROM Auctions auct
	INNER JOIN AuctionStatuses asta ON auct.AuctionStatusId = asta.AuctionStatusId
		AND (auct.Deleted = 0)
		AND (auct.EndDate >= CONVERT(DATE, GETDATE()))
	ORDER BY (CASE WHEN auct.StartDate IS NULL THEN 1 ELSE 0 END) DESC, 
         auct.StartDate DESC
		--	(CASE WHEN @sortByColumn = 'AuctionName' AND @sortingDirection  = 'asc' THEN auct.AuctionName END) ASC,    
		--	(CASE WHEN @sortByColumn = 'AuctionName' AND @sortingDirection  = 'desc' THEN auct.AuctionName END) DESC,    
		--	(CASE WHEN @sortByColumn = 'AuctionStartingPrice'  AND @sortingDirection  = 'asc' THEN auct.AuctionStartingPrice END) ASC,
		--	(CASE WHEN @sortByColumn = 'AuctionStartingPrice'  AND @sortingDirection  = 'desc' THEN auct.AuctionStartingPrice END) DESC,
		--	(CASE WHEN @sortByColumn = 'AuctionStartDate' AND @sortingDirection  = 'asc'  THEN auct.AuctionStartDate END) ASC,
		--	(CASE WHEN @sortByColumn = 'AuctionStartDate' AND @sortingDirection  = 'desc' THEN auct.AuctionStartDate END) DESC,
		--	(CASE WHEN @sortByColumn = 'AuctionEndDate' AND @sortingDirection  = 'asc'  THEN auct.AuctionEndDate END) ASC,
		--	(CASE WHEN @sortByColumn = 'AuctionEndDate' AND @sortingDirection  = 'desc' THEN auct.AuctionEndDate END) DESC
		OFFSET @start ROWS

	FETCH NEXT @end ROWS ONLY
END