namespace Book_Manager.Forms
{
    partial class Menu
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
            btnListBookSales = new Button();
            btnListSales = new Button();
            btnPrint = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 39);
            label1.Name = "label1";
            label1.Size = new Size(254, 38);
            label1.TabIndex = 0;
            label1.Text = "Bạn muốn làm gì?";
            // 
            // btnListBookSales
            // 
            btnListBookSales.Font = new Font("Segoe UI", 13.8F);
            btnListBookSales.Location = new Point(97, 126);
            btnListBookSales.Name = "btnListBookSales";
            btnListBookSales.Size = new Size(360, 72);
            btnListBookSales.TabIndex = 1;
            btnListBookSales.Text = "Xem danh sách BookSales";
            btnListBookSales.UseVisualStyleBackColor = true;
            btnListBookSales.Click += btnListBookSales_Click;
            // 
            // btnListSales
            // 
            btnListSales.Font = new Font("Segoe UI", 13.8F);
            btnListSales.Location = new Point(97, 222);
            btnListSales.Name = "btnListSales";
            btnListSales.Size = new Size(360, 72);
            btnListSales.TabIndex = 2;
            btnListSales.Text = "Lịch sử bán hàng";
            btnListSales.UseVisualStyleBackColor = true;
            btnListSales.Click += btnListSales_Click;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI", 13.8F);
            btnPrint.Location = new Point(97, 318);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(360, 72);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "In hóa đơn";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 450);
            Controls.Add(btnPrint);
            Controls.Add(btnListSales);
            Controls.Add(btnListBookSales);
            Controls.Add(label1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tổng quan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnListBookSales;
        private Button btnListSales;
        private Button btnPrint;
    }
}