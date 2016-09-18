namespace Cashier_System
{
    partial class Add_new_Item
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.price_tb = new System.Windows.Forms.TextBox();
            this.code_tb = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.quantity_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bprice_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.discount_tb = new System.Windows.Forms.TextBox();
            this.description_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statues_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "بار كود";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المنتج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "سعر البيع";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "الكميه";
            // 
            // price_tb
            // 
            this.price_tb.Location = new System.Drawing.Point(142, 138);
            this.price_tb.Name = "price_tb";
            this.price_tb.Size = new System.Drawing.Size(97, 20);
            this.price_tb.TabIndex = 4;
            // 
            // code_tb
            // 
            this.code_tb.Location = new System.Drawing.Point(142, 30);
            this.code_tb.Name = "code_tb";
            this.code_tb.Size = new System.Drawing.Size(303, 20);
            this.code_tb.TabIndex = 5;
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(142, 78);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(303, 20);
            this.name_tb.TabIndex = 6;
            // 
            // quantity_tb
            // 
            this.quantity_tb.Location = new System.Drawing.Point(142, 199);
            this.quantity_tb.Name = "quantity_tb";
            this.quantity_tb.Size = new System.Drawing.Size(97, 20);
            this.quantity_tb.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "سعر الشراء";
            // 
            // bprice_tb
            // 
            this.bprice_tb.Location = new System.Drawing.Point(345, 135);
            this.bprice_tb.Name = "bprice_tb";
            this.bprice_tb.Size = new System.Drawing.Size(100, 20);
            this.bprice_tb.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "الخصم";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "وصف";
            // 
            // discount_tb
            // 
            this.discount_tb.Location = new System.Drawing.Point(345, 192);
            this.discount_tb.Name = "discount_tb";
            this.discount_tb.Size = new System.Drawing.Size(100, 20);
            this.discount_tb.TabIndex = 12;
            // 
            // description_tb
            // 
            this.description_tb.Location = new System.Drawing.Point(142, 237);
            this.description_tb.Multiline = true;
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(303, 20);
            this.description_tb.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "اضافه";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "الغاء";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statues_lbl
            // 
            this.statues_lbl.AutoSize = true;
            this.statues_lbl.Location = new System.Drawing.Point(357, 321);
            this.statues_lbl.Name = "statues_lbl";
            this.statues_lbl.Size = new System.Drawing.Size(0, 13);
            this.statues_lbl.TabIndex = 16;
            // 
            // Add_new_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 348);
            this.Controls.Add(this.statues_lbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.discount_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bprice_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantity_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.code_tb);
            this.Controls.Add(this.price_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_new_Item";
            this.Text = "اضافه منتج جديد";
            this.Load += new System.EventHandler(this.Add_new_Item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox price_tb;
        private System.Windows.Forms.TextBox code_tb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox quantity_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bprice_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox discount_tb;
        private System.Windows.Forms.TextBox description_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label statues_lbl;
    }
}