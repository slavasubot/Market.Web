﻿using System;
using System.Collections.Generic;

namespace Market.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Planned { get; set; }
        public decimal Spent { get; set; }
        public decimal PurchasesCost { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
        
    }
}
