﻿using CRM_BL.Model;
using System;
using System.Windows.Forms;

namespace CRM_Ui
{
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }
        public SellerForm()
        {
            InitializeComponent();
        }
        public SellerForm(Seller seller) : this()
        {
            Seller = seller;
            textBox1.Text = seller.Name;

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = Seller ?? new Seller();
            s.Name = textBox1.Text;
            Close();
        }
    }
}
