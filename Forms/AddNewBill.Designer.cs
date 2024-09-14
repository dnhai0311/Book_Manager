namespace Book_Manager.Forms
{
    partial class AddNewBill
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            tạoMớiToolStripMenuItem = new ToolStripMenuItem();
            tínhToánToolStripMenuItem = new ToolStripMenuItem();
            quayLạiToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            lbQuantity = new Label();
            txtDiscount = new TextBox();
            txtExtendedPrice = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            label6 = new Label();
            cbTitle = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbNextDue = new Label();
            cbDiscount = new CheckBox();
            cbStudentDiscount = new CheckBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(425, 290);
            label1.Name = "label1";
            label1.Size = new Size(151, 38);
            label1.TabIndex = 0;
            label1.Text = "Tổng tiền:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, quayLạiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(732, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tạoMớiToolStripMenuItem, tínhToánToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // tạoMớiToolStripMenuItem
            // 
            tạoMớiToolStripMenuItem.Name = "tạoMớiToolStripMenuItem";
            tạoMớiToolStripMenuItem.Size = new Size(163, 26);
            tạoMớiToolStripMenuItem.Text = "Tạo mới";
            tạoMớiToolStripMenuItem.Click += tạoMớiToolStripMenuItem_Click;
            // 
            // tínhToánToolStripMenuItem
            // 
            tínhToánToolStripMenuItem.Name = "tínhToánToolStripMenuItem";
            tínhToánToolStripMenuItem.Size = new Size(163, 26);
            tínhToánToolStripMenuItem.Text = "In hóa đơn";
            // 
            // quayLạiToolStripMenuItem
            // 
            quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            quayLạiToolStripMenuItem.Size = new Size(77, 24);
            quayLạiToolStripMenuItem.Text = "Quay lại";
            quayLạiToolStripMenuItem.Click += quayLạiToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbQuantity);
            groupBox1.Controls.Add(txtDiscount);
            groupBox1.Controls.Add(txtExtendedPrice);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbTitle);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 286);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbQuantity.Location = new Point(238, 107);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(0, 20);
            lbQuantity.TabIndex = 6;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(80, 244);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(152, 27);
            txtDiscount.TabIndex = 5;
            // 
            // txtExtendedPrice
            // 
            txtExtendedPrice.Location = new Point(80, 196);
            txtExtendedPrice.Name = "txtExtendedPrice";
            txtExtendedPrice.ReadOnly = true;
            txtExtendedPrice.Size = new Size(152, 27);
            txtExtendedPrice.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(80, 152);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(152, 27);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(80, 104);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(152, 27);
            txtQuantity.TabIndex = 2;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 247);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 3;
            label6.Text = "Giảm";
            // 
            // cbTitle
            // 
            cbTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTitle.FormattingEnabled = true;
            cbTitle.Location = new Point(80, 46);
            cbTitle.Name = "cbTitle";
            cbTitle.Size = new Size(305, 28);
            cbTitle.TabIndex = 1;
            cbTitle.SelectedIndexChanged += cbTitle_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 199);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 3;
            label5.Text = "Tổng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 107);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 155);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 3;
            label3.Text = "Giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 49);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "Tiêu đề";
            // 
            // lbNextDue
            // 
            lbNextDue.AutoSize = true;
            lbNextDue.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNextDue.Location = new Point(564, 297);
            lbNextDue.Name = "lbNextDue";
            lbNextDue.Size = new Size(0, 31);
            lbNextDue.TabIndex = 0;
            // 
            // cbDiscount
            // 
            cbDiscount.AutoSize = true;
            cbDiscount.Enabled = false;
            cbDiscount.Location = new Point(425, 55);
            cbDiscount.Name = "cbDiscount";
            cbDiscount.Size = new Size(123, 24);
            cbDiscount.TabIndex = 3;
            cbDiscount.Text = "Giảm giá 10%";
            cbDiscount.UseVisualStyleBackColor = true;
            cbDiscount.CheckedChanged += cbDiscount_CheckedChanged;
            // 
            // cbStudentDiscount
            // 
            cbStudentDiscount.AutoSize = true;
            cbStudentDiscount.Enabled = false;
            cbStudentDiscount.Location = new Point(425, 90);
            cbStudentDiscount.Name = "cbStudentDiscount";
            cbStudentDiscount.Size = new Size(209, 24);
            cbStudentDiscount.TabIndex = 3;
            cbStudentDiscount.Text = "Giảm giá cho học sinh 15%";
            cbStudentDiscount.UseVisualStyleBackColor = true;
            cbStudentDiscount.CheckedChanged += cbDiscount_CheckedChanged;
            // 
            // AddNewBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 350);
            Controls.Add(cbStudentDiscount);
            Controls.Add(cbDiscount);
            Controls.Add(groupBox1);
            Controls.Add(lbNextDue);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AddNewBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo hóa đơn";
            Load += AddNewBill_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem tạoMớiToolStripMenuItem;
        private ToolStripMenuItem tínhToánToolStripMenuItem;
        private ToolStripMenuItem quayLạiToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtDiscount;
        private TextBox txtExtendedPrice;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label label6;
        private ComboBox cbTitle;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lbNextDue;
        private Label lbQuantity;
        private CheckBox cbDiscount;
        private CheckBox cbStudentDiscount;
    }
}