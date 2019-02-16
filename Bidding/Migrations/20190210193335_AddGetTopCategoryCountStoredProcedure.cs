﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Bidding.Migrations
{
    public partial class AddGetTopCategoryCountStoredProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE GetTopCategoriesWithCount
                        AS
                        BEGIN
                            SELECT
		                        cat.CategoryId,
		                        cat.CategoryName,
		                        SUM(CASE
			                        WHEN acat.CategoryId = cat.CategoryId THEN 1
			                        ELSE 0
		                        END) AS CategoryTotalCount
                            FROM Categories cat
                            INNER JOIN AuctionCategories acat
                            ON cat.CategoryId = acat.CategoryId
                            GROUP BY cat.CategoryId,
                                     cat.CategoryName
                        END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROCEDURE GetTopCategoriesWithCount;";

            migrationBuilder.Sql(sp);
        }
    }
}