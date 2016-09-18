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
    public partial class Product_Details : Form
    {

        DAL db = new DAL();
        
        public Product_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String Product_Code = code_tb.Text;
            bool Success = db.Update("product_tbl", Constants.product_keys, CollectDataFromUI(), "product_code", code_tb.Text);
            if (Success)
            {
                statues_lbl.ForeColor = Color.Green ;
                statues_lbl.Text = "تم التعديل بنجاح";
            }
            else
            {
                statues_lbl.ForeColor = Color.Red;
                statues_lbl.Text = "خطأ فى العمليه .. يرجى المحاوله مجددا";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String key = "product_code", value = code_tb.Text, table_name = "product_tbl";
            DataSet oldData = new DataSet();
            oldData = db.find(table_name, key, value);

            if (oldData.Tables[0].Rows.Count == 0)
            {
                statues_lbl.ForeColor = Color.Red;
                statues_lbl.Text = "هذا المنتج غير موجود";
            }
            else
            {
                PopulateUI(oldData);
            }

        }


        void PopulateUI(DataSet oldData)
        {
                code_tb.Enabled = false;
                statues_lbl.Text = "";
                price_tb.Text = oldData.Tables[0].Rows[0][2].ToString();
                bprice_tb.Text = oldData.Tables[0].Rows[0][3].ToString();
                description_tb.Text = oldData.Tables[0].Rows[0][4].ToString();
                name_tb.Text = oldData.Tables[0].Rows[0][5].ToString();
                discount_tb.Text = oldData.Tables[0].Rows[0][6].ToString();
                quantity_tb.Text = oldData.Tables[0].Rows[0][7].ToString();
                history_tb.Text = oldData.Tables[0].Rows[0][8].ToString();            
        }


        List<String> CollectDataFromUI()
        {
            List<String> values = new List<string>();
            values.Add(code_tb.Text);
            values.Add(price_tb.Text);
            values.Add(bprice_tb.Text);
            values.Add(description_tb.Text);
            values.Add(name_tb.Text);
            values.Add(discount_tb.Text);
            values.Add(quantity_tb.Text);
            values.Add(history_tb.Text);
            return values;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }
    }
}
