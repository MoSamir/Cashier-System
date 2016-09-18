using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemFile_Click(object sender, EventArgs e)
        {
          
        }

        private void ToolStripMenuItemAddItem_Click(object sender, EventArgs e)
        {
            Add_new_Item new_Item = new Add_new_Item();
            new_Item.Show();
        }



        private void ToolStripMenuItemEditItem_Click_1(object sender, EventArgs e)
        {
            Product_Details product_details = new Product_Details();
            product_details.Show();
        }
    }
}
