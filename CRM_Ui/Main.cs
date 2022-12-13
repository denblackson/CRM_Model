using CRM_BL.Model;
using System;
using System.Windows.Forms;

namespace CRM_Ui
{
    public partial class Main : Form
    {
        CRM_Context db;
        public Main()
        {
            InitializeComponent();
            db = new CRM_Context();
        }


        private void goodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Products);
            catalogProduct.Show();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProducts = new Catalog<Product>(db.Products);
            catalogProducts.Show();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(db.Sellers);
            catalogSeller.Show();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCustomer= new Catalog<Customer>(db.Customers);
            catalogCustomer.Show();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCheck = new Catalog<Check>(db.Checks);
            catalogCheck.Show();
        }

        private void addSellerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new SellerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Sellers.Add(form.Seller);
                db.SaveChanges();
            }
        }

        private void addCustomerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog()== DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();   
            }
        }

        private void addGoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Products.Add(form.Product);
                db.SaveChanges();
            }
        }
    }
}
