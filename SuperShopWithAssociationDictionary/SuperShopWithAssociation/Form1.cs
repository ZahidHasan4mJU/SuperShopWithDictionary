using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopWithAssociation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Shop aShop;
        private Item anItem;

        private void saveButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop(shopNameTextBox.Text, shopAddressTextBox.Text);
            MessageBox.Show("Save successfully");

        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            anItem = new Item(itemIdTextBox.Text,Convert.ToDouble(quantityTextBox.Text));
            string msg = aShop.add(anItem);
            MessageBox.Show(msg);

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aShop.getResult());
        }
    }
}
