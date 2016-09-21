namespace Cashier_System
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.EmployeesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "ملف";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddItem,
            this.ToolStripMenuItemEditItem});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(76, 20);
            this.ToolStripMenuItemFile.Text = "اداره منتجات";
            this.ToolStripMenuItemFile.Click += new System.EventHandler(this.ToolStripMenuItemFile_Click);
            // 
            // ToolStripMenuItemAddItem
            // 
            this.ToolStripMenuItemAddItem.Name = "ToolStripMenuItemAddItem";
            this.ToolStripMenuItemAddItem.Size = new System.Drawing.Size(125, 22);
            this.ToolStripMenuItemAddItem.Text = "اضافه منتج";
            this.ToolStripMenuItemAddItem.Click += new System.EventHandler(this.ToolStripMenuItemAddItem_Click);
            // 
            // ToolStripMenuItemEditItem
            // 
            this.ToolStripMenuItemEditItem.Name = "ToolStripMenuItemEditItem";
            this.ToolStripMenuItemEditItem.Size = new System.Drawing.Size(125, 22);
            this.ToolStripMenuItemEditItem.Text = "تعديل منتج";
            this.ToolStripMenuItemEditItem.Click += new System.EventHandler(this.ToolStripMenuItemEditItem_Click_1);
            // 
            // EmployeesToolStripMenuItem
            // 
            this.EmployeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewEmployeeToolStripMenuItem});
            this.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem";
            this.EmployeesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.EmployeesToolStripMenuItem.Text = "اداره العماله";
            // 
            // NewEmployeeToolStripMenuItem
            // 
            this.NewEmployeeToolStripMenuItem.Name = "NewEmployeeToolStripMenuItem";
            this.NewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NewEmployeeToolStripMenuItem.Text = "اضافه عامل جديد";
            this.NewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.NewEmployeeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewEmployeeToolStripMenuItem;
    }
}

