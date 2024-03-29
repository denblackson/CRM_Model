﻿using CRM_BL.Model;
using System;
using System.Windows.Forms;

namespace CRM_Ui
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }
        public ProductForm()
        {
            InitializeComponent();
        }
        public ProductForm(Product product) : this()
        {
            Product = product;
            textBox1.Text = Product.Name;
            numericUpDown1.Value = Product.Price;
            numericUpDown2.Value = Product.Count;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = Product ?? new Product();
            p.Name = textBox1.Text;
            p.Price = numericUpDown1.Value;
            p.Count = Convert.ToInt32(numericUpDown2.Value);

            Close();
        }
    }
}
