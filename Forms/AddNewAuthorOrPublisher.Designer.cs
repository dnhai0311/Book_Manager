namespace Book_Manager.Forms
{
    partial class AddNewAuthorOrPublisher
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
            txtName = new TextBox();
            lbName = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(49, 101);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Hãy nhập tên vào đây";
            txtName.Size = new Size(421, 27);
            txtName.TabIndex = 0;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(49, 36);
            lbName.Name = "lbName";
            lbName.Size = new Size(123, 38);
            lbName.TabIndex = 1;
            lbName.Text = "Tên của ";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(49, 157);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(244, 29);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Thêm mới";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddNewAuthorOrPublisher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 209);
            Controls.Add(btnSubmit);
            Controls.Add(lbName);
            Controls.Add(txtName);
            Name = "AddNewAuthorOrPublisher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm mới ";
            Load += AddNewAuthorOrPublisher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lbName;
        private Button btnSubmit;
    }
}