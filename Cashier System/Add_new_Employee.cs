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

    public partial class Add_new_Employee : Form
    {

        

        public Add_new_Employee()
        {
            InitializeComponent();
        }


        Boolean CompleteInput()
        {

            if ((username_tb.Text == "") || (password_tb.Text == ""))
                return false;

            if ((name_tb.Text == "") || (job_cb.SelectedItem == null))
                return false;

            return true;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DAL db = new DAL();
            if (CompleteInput()) { 
                String UserName = "N'" + username_tb.Text + "'";
                String Password = "N'" + password_tb.Text + "'";
                String Name = "N'" + name_tb.Text + "'";
                String Job = job_cb.SelectedIndex.ToString();
            List<String> values = new List<String>(){UserName , Password , Name , Job};

            if (db.Add("seller_tbl", Constants.seller_keys, values) == true)
            {
                statues_lbl.ForeColor = Color.Green ;
                statues_lbl.Text = "تم الاضافه بنجاح";
            }
            else
            {
                statues_lbl.ForeColor = Color.Red;
                statues_lbl.Text = "حدث خطأ اثناء الاضافه .. يرجى الاعاده مجددا";
            }

            username_tb.Clear();
            password_tb.Clear();
            name_tb.Clear();
            job_cb.SelectedItem = null;
            values.Clear();
            return;
            }
            else
            {
                statues_lbl.ForeColor = Color.Red;
                statues_lbl.Text = "يرجى ملأ البيانات بطريقه كامله";
                return;
            }
        }


        private void username_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password_tb.Focus();
            }
        }

        private void password_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                name_tb.Focus();
            }
        }

        private void name_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                job_cb.Focus();
            }
        }

        private void job_cb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

    }
}
