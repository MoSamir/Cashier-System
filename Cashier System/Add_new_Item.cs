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
            this.ActiveControl = code_tb;
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
            int Quantity ;
            float Discount , Price, Bprice ;
            bool error_found = false;
            if(discount_tb.Text == "") discount_tb.Text = "0.0";
            if (int.TryParse(quantity_tb.Text, out Quantity) == false || int.Parse(quantity_tb.Text) < 0)
            {

                quantity_tb.Text = "الكميه بالسالب";
                quantity_tb.BackColor = Color.Red;
                error_found = true;
            }else{
                quantity_tb.BackColor = Color.White;
            }


            if (float.TryParse(discount_tb.Text, out Discount) == false || float.Parse(discount_tb.Text) < 0)
            {
                discount_tb.Text = "الحصم بالسالب";
                discount_tb.BackColor = Color.Red;
                error_found = true;
            }else{ 
                discount_tb.BackColor = Color.White;
            }


            if (float.TryParse(price_tb.Text, out Price) == false || float.Parse(price_tb.Text) < 0)
            {
                price_tb.Text = "ثمن البيع بالسالب";
                price_tb.BackColor = Color.Red;
                error_found = true;
            }else{ 
                price_tb.BackColor = Color.White;
            }

            if (float.TryParse(bprice_tb.Text, out Bprice) == false || float.Parse(bprice_tb.Text) < 0)
            {

                bprice_tb.Text = "تمن الشراء بالسالب";
                bprice_tb.BackColor = Color.Red;
                error_found = true;
            }else{ 
                bprice_tb.BackColor = Color.White;
            }


            if (code_tb.Text == "")
            {
                code_tb.Text = "يجب اضافه كود للمنتج";
                code_tb.BackColor = Color.Red;
                error_found = true;
            } else
                code_tb.BackColor = Color.White;

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
                
                DataSet DS = db.finds("product_tbl", "product_code", code_tb.Text);
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
                    return;
                }

                code_tb.Clear();        code_tb.BackColor = Color.White;
                name_tb.Clear();        name_tb.BackColor = Color.White;
                bprice_tb.Clear();      bprice_tb.BackColor = Color.White;
                price_tb.Clear();       price_tb.BackColor = Color.White;
                quantity_tb.Clear();    quantity_tb.BackColor = Color.White;
                discount_tb.Clear();    discount_tb.BackColor = Color.White;
                description_tb.Clear(); description_tb.BackColor = Color.White;
                code_tb.Focus();        
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

        private void code_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter){
                name_tb.Focus();
            }
        }

        private void name_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bprice_tb.Focus();
            }
        }

        private void bprice_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                price_tb.Focus();
            }
        }

        private void price_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                discount_tb.Focus();
            }
        }

        private void discount_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                quantity_tb.Focus();
            }
        }

        private void quantity_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                description_tb.Focus();
            }
        }

        private void description_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }
    }
}
