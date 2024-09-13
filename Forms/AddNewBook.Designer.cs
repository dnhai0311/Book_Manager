namespace Book_Manager.Forms
{
    partial class AddNewBook
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
            txtName = new TextBox();
            pbImage = new PictureBox();
            btnChangeImg = new Button();
            label2 = new Label();
            label3 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            txtQuantity = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnAddNew = new Button();
            cbAuthor = new ComboBox();
            cbPublisher = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 27);
            label1.Name = "label1";
            label1.Size = new Size(216, 38);
            label1.TabIndex = 0;
            label1.Text = "Thêm sách mới";
            // 
            // txtName
            // 
            txtName.Location = new Point(462, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 27);
            txtName.TabIndex = 1;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(39, 122);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(217, 263);
            pbImage.TabIndex = 2;
            pbImage.TabStop = false;
            // 
            // btnChangeImg
            // 
            btnChangeImg.Location = new Point(99, 422);
            btnChangeImg.Name = "btnChangeImg";
            btnChangeImg.Size = new Size(94, 29);
            btnChangeImg.TabIndex = 6;
            btnChangeImg.Text = "Sửa ảnh";
            btnChangeImg.UseVisualStyleBackColor = true;
            btnChangeImg.Click += btnChangeImg_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 125);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 190);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 0;
            label3.Text = "Giá";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(462, 187);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(236, 27);
            txtPrice.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 247);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 0;
            label4.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(462, 244);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(236, 27);
            txtQuantity.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 309);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 0;
            label5.Text = "Tác giả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(360, 372);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 0;
            label6.Text = "Nhà xuất bản";
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(533, 429);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 29);
            btnAddNew.TabIndex = 7;
            btnAddNew.Text = "Thêm mới";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // cbAuthor
            // 
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(462, 306);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(236, 28);
            cbAuthor.TabIndex = 4;
            // 
            // cbPublisher
            // 
            cbPublisher.FormattingEnabled = true;
            cbPublisher.Location = new Point(462, 369);
            cbPublisher.Name = "cbPublisher";
            cbPublisher.Size = new Size(236, 28);
            cbPublisher.TabIndex = 5;
            // 
            // AddNewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 501);
            Controls.Add(cbPublisher);
            Controls.Add(cbAuthor);
            Controls.Add(btnAddNew);
            Controls.Add(btnChangeImg);
            Controls.Add(pbImage);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtQuantity);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddNewBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm sách mới";
            Load += AddNewBook_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private PictureBox pbImage;
        private Button btnChangeImg;
        private Label label2;
        private Label label3;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtQuantity;
        private Label label5;
        private Label label6;
        private Button btnAddNew;
        private ComboBox cbAuthor;
        private ComboBox cbPublisher;
    }
}