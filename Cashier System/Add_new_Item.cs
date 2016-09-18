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
    public partial class Add_new_Item : Form
    {
        public Add_new_Item()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Add_new_Item_Load(object sender, EventArgs e)
        {

        }


        private bool CompleteInput(){

            if ((code_tb.Text == "") || (name_tb.Text == "") || (quantity_tb.Text == ""))
                return false;

            if ((price_tb.Text == "") || (bprice_tb.Text == ""))
                return false;
            return true;
        }

        private bool ValidInput(){
            int int_test ;
            float float_test ;
            bool error_found = false;
            if(discount_tb.Text == "") discount_tb.Text = "0.0";
            if (int.TryParse(quantity_tb.Text, out int_test) == false) {
                quantity_tb.BackColor = Color.Red;
                error_found = true;
            }

            if (float.TryParse(discount_tb.Text, out float_test) == false)
            {
                discount_tb.BackColor = Color.Red;
                error_found = true;
            }

            if (float.TryParse(price_tb.Text, out float_test) == false)
            {
                price_tb.BackColor = Color.Red;
                error_found = true;
            }

            if (float.TryParse(bprice_tb.Text, out float_test) == false)
            {
                bprice_tb.BackColor = Color.Red;
                error_found = true;
            }

            if (code_tb.Text == "")
            {
                code_tb.BackColor = Color.Red;
                error_found = true;
            }
            return !error_found;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DAL db = new DAL();
            if (CompleteInput() && ValidInput())
            {

                List<String> values = new List<String>() { code_tb.Text , price_tb.Text 
                , bprice_tb.Text , description_tb.Text , name_tb.Text , discount_tb.Text 
                , quantity_tb.Text , "0" };
                
                DataSet DS = db.find("product_tbl", "product_code", code_tb.Text);
                if (DS.Tables[0].Rows.Count != 0)
                {
                    statues_lbl.ForeColor = Color.Red;
                    statues_lbl.Text = "المنتج موجود بالفعل";
                    
                }

                else if (db.Add("product_tbl", Constants.product_keys, values))
                {
                    statues_lbl.ForeColor = Color.Green;
                    statues_lbl.Text = "تم اضافه المنتج";
                }
                else
                {
                    statues_lbl.ForeColor = Color.Red;
                    statues_lbl.Text = "حدث خظأ اثناء الاضافه .. حاول مجددا";
                    values.Clear();
                }
                
                values.Clear();
                return;
            }
            else
            {
                statues_lbl.ForeColor = Color.Red;
                statues_lbl.Text = "برجاء ادخال البيانات كامله و بطريقه صحيحه ";
                return; 
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }
    }
}
