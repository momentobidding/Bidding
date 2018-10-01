﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bidding.Models.DatabaseModels.Bidding.Subscribe
{
    public partial class Newsletter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Vehicles { get; set; }
        public bool Items { get; set; }
        public bool Companies { get; set; }
        public bool Estate { get; set; }
        public bool Brands { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}