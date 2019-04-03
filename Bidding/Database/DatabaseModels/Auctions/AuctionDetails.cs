﻿using Bidding.Database.DatabaseModels.Auctions;
using BiddingAPI.Models.DatabaseModels;
using BiddingAPI.Models.DatabaseModels.Bidding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BiddingAPI.Models.DatabaseModels.Bidding
{
    public class AuctionDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuctionDetailsId { get; set; }
        public string AuctionDescription { get; set;}

        // Relationship definitions

        // [ForeignKey("Auction")]
        public int AuctionId {get;set;}
        public Auction Auction { get; set; }
 

        [Required]
        public int AuctionFormatId { get; set; }
        public AuctionFormat AuctionFormat { get; set; }

        public int AuctionConditionId { get; set; }
        public AuctionCondition AuctionCondition { get; set; }



    }
}
