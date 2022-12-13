﻿namespace CRM_BL.Model
{
    public class Sell
    {
        public int SellId { get; set; }
        public int ChekId { get; set; }
        public int ProductId { get; set; }

        public virtual Check Check { get; set; }
        public virtual Product Product { get; set; }
    }
}
