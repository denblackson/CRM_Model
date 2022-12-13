using System.Data.Entity;

namespace CRM_BL.Model
{
    public class CRM_Context : DbContext
    {
        public CRM_Context() : base("CRM_Connection") { }

        public DbSet<Check> Checks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public  DbSet<Sell> Sells { get; set; }
        public  DbSet<Seller> Sellers { get; set; }
    }
}
