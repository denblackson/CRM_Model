﻿using System.Collections.Generic;

namespace CRM_BL.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return Name;
        }
        public override bool Equals(object obj)
        {
            if (obj is Product product)
            {
                return ProductId.Equals(product.ProductId);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return ProductId;
        }
    }
}
