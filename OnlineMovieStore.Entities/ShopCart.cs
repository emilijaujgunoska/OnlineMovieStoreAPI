﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
    public class ShopCart
    {
        [Key]
        public int Id { get; set; }

        public double Price { get; set; }

        public DateTime DateAdded { get; set; }

       
        [StringLength(100)]
        public string UserId { get; set; } = null!;

        public int MovieId { get; set; }

        public string? PromoCode { get; set; }

        public bool IfPromoCode { get; set; } 
    }
}
