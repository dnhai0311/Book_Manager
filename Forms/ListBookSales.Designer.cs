namespace Book_Manager.Forms
{
    partial class ListBookSales
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
            components = new System.ComponentModel.Container();
            dgvListBookSales = new DataGridView();
            label1 = new Label();
            txtSearch = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            thêmSáchMớiToolStripMenuItem = new ToolStripMenuItem();
            thêmTácGiảMớiToolStripMenuItem = new ToolStripMenuItem();
            thêmNhàXuấtBảnMớiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            sáchMớiToolStripMenuItem = new ToolStripMenuItem();
            tácGiảMớiToolStripMenuItem = new ToolStripMenuItem();
            nhàXuấtBảnMớiToolStripMenuItem = new ToolStripMenuItem();
            xemToolStripMenuItem = new ToolStripMenuItem();
            danhSáchTácGiảToolStripMenuItem = new ToolStripMenuItem();
            danhSáchNhàXuấtBảnToolStripMenuItem = new ToolStripMenuItem();
            quayLạiToolStripMenuItem = new ToolStripMenuItem();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            img = new DataGridViewImageColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            author = new DataGridViewComboBoxColumn();
            publisher = new DataGridViewComboBoxColumn();
            modify = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListBookSales).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListBookSales
            // 
            dgvListBookSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListBookSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListBookSales.Columns.AddRange(new DataGridViewColumn[] { id, name, img, price, quantity, author, publisher, modify, delete });
            dgvListBookSales.Location = new Point(12, 102);
            dgvListBookSales.Name = "dgvListBookSales";
            dgvListBookSales.RowHeadersWidth = 51;
            dgvListBookSales.Size = new Size(1317, 350);
            dgvListBookSales.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(541, 42);
            label1.Name = "label1";
            label1.Size = new Size(294, 38);
            label1.TabIndex = 1;
            label1.Text = "Danh sách BookSales";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(917, 53);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Hãy nhập thứ bạn muốn tìm kiếm...";
            txtSearch.Size = new Size(412, 27);
            txtSearch.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { thêmSáchMớiToolStripMenuItem, thêmTácGiảMớiToolStripMenuItem, thêmNhàXuấtBảnMớiToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(235, 76);
            // 
            // thêmSáchMớiToolStripMenuItem
            // 
            thêmSáchMớiToolStripMenuItem.Name = "thêmSáchMớiToolStripMenuItem";
            thêmSáchMớiToolStripMenuItem.Size = new Size(234, 24);
            thêmSáchMớiToolStripMenuItem.Text = "Thêm sách mới";
            // 
            // thêmTácGiảMớiToolStripMenuItem
            // 
            thêmTácGiảMớiToolStripMenuItem.Name = "thêmTácGiảMớiToolStripMenuItem";
            thêmTácGiảMớiToolStripMenuItem.Size = new Size(234, 24);
            thêmTácGiảMớiToolStripMenuItem.Text = "Thêm tác giả mới";
            // 
            // thêmNhàXuấtBảnMớiToolStripMenuItem
            // 
            thêmNhàXuấtBảnMớiToolStripMenuItem.Name = "thêmNhàXuấtBảnMớiToolStripMenuItem";
            thêmNhàXuấtBảnMớiToolStripMenuItem.Size = new Size(234, 24);
            thêmNhàXuấtBảnMớiToolStripMenuItem.Text = "Thêm nhà xuất bản mới";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, xemToolStripMenuItem, quayLạiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1341, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { sáchMớiToolStripMenuItem, tácGiảMớiToolStripMenuItem, nhàXuấtBảnMớiToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(60, 24);
            toolStripMenuItem1.Text = "Thêm";
            // 
            // sáchMớiToolStripMenuItem
            // 
            sáchMớiToolStripMenuItem.Name = "sáchMớiToolStripMenuItem";
            sáchMớiToolStripMenuItem.Size = new Size(210, 26);
            sáchMớiToolStripMenuItem.Text = "Sách mới";
            sáchMớiToolStripMenuItem.Click += SáchMớiToolStripMenuItem_Click;
            // 
            // tácGiảMớiToolStripMenuItem
            // 
            tácGiảMớiToolStripMenuItem.Name = "tácGiảMớiToolStripMenuItem";
            tácGiảMớiToolStripMenuItem.Size = new Size(210, 26);
            tácGiảMớiToolStripMenuItem.Text = "Tác giả mới";
            tácGiảMớiToolStripMenuItem.Click += TácGiảMớiToolStripMenuItem_Click;
            // 
            // nhàXuấtBảnMớiToolStripMenuItem
            // 
            nhàXuấtBảnMớiToolStripMenuItem.Name = "nhàXuấtBảnMớiToolStripMenuItem";
            nhàXuấtBảnMớiToolStripMenuItem.Size = new Size(210, 26);
            nhàXuấtBảnMớiToolStripMenuItem.Text = "Nhà xuất bản mới";
            nhàXuấtBảnMớiToolStripMenuItem.Click += NhàXuấtBảnMớiToolStripMenuItem_Click;
            // 
            // xemToolStripMenuItem
            // 
            xemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { danhSáchTácGiảToolStripMenuItem, danhSáchNhàXuấtBảnToolStripMenuItem });
            xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            xemToolStripMenuItem.Size = new Size(53, 24);
            xemToolStripMenuItem.Text = "Xem";
            // 
            // danhSáchTácGiảToolStripMenuItem
            // 
            danhSáchTácGiảToolStripMenuItem.Name = "danhSáchTácGiảToolStripMenuItem";
            danhSáchTácGiảToolStripMenuItem.Size = new Size(249, 26);
            danhSáchTácGiảToolStripMenuItem.Text = "Danh sách tác giả";
            // 
            // danhSáchNhàXuấtBảnToolStripMenuItem
            // 
            danhSáchNhàXuấtBảnToolStripMenuItem.Name = "danhSáchNhàXuấtBảnToolStripMenuItem";
            danhSáchNhàXuấtBảnToolStripMenuItem.Size = new Size(249, 26);
            danhSáchNhàXuấtBảnToolStripMenuItem.Text = "Danh sách nhà xuất bản";
            // 
            // quayLạiToolStripMenuItem
            // 
            quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            quayLạiToolStripMenuItem.Size = new Size(77, 24);
            quayLạiToolStripMenuItem.Text = "Quay lại";
            quayLạiToolStripMenuItem.Click += quayLạiToolStripMenuItem_Click;
            // 
            // id
            // 
            id.HeaderText = "STT";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Tên sách";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // img
            // 
            img.HeaderText = "Hình ảnh";
            img.MinimumWidth = 6;
            img.Name = "img";
            img.ReadOnly = true;
            // 
            // price
            // 
            price.HeaderText = "Giá";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.HeaderText = "Số lượng";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // author
            // 
            author.HeaderText = "Tác giả";
            author.MinimumWidth = 6;
            author.Name = "author";
            author.ReadOnly = true;
            author.Resizable = DataGridViewTriState.True;
            author.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // publisher
            // 
            publisher.HeaderText = "Nhà xuất bản";
            publisher.MinimumWidth = 6;
            publisher.Name = "publisher";
            publisher.ReadOnly = true;
            publisher.Resizable = DataGridViewTriState.True;
            publisher.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // modify
            // 
            modify.HeaderText = "";
            modify.MinimumWidth = 6;
            modify.Name = "modify";
            modify.Text = "Sửa";
            modify.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            delete.HeaderText = "";
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.Text = "Xóa";
            delete.UseColumnTextForButtonValue = true;
            // 
            // ListBookSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 465);
            Controls.Add(menuStrip1);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dgvListBookSales);
            MainMenuStrip = menuStrip1;
            Name = "ListBookSales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListBookSales";
            Load += ListBookSales_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListBookSales).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListBookSales;
        private Label label1;
        private TextBox txtSearch;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem thêmSáchMớiToolStripMenuItem;
        private ToolStripMenuItem thêmTácGiảMớiToolStripMenuItem;
        private ToolStripMenuItem thêmNhàXuấtBảnMớiToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem sáchMớiToolStripMenuItem;
        private ToolStripMenuItem tácGiảMớiToolStripMenuItem;
        private ToolStripMenuItem nhàXuấtBảnMớiToolStripMenuItem;
        private ToolStripMenuItem xemToolStripMenuItem;
        private ToolStripMenuItem danhSáchTácGiảToolStripMenuItem;
        private ToolStripMenuItem danhSáchNhàXuấtBảnToolStripMenuItem;
        private ToolStripMenuItem quayLạiToolStripMenuItem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewImageColumn img;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewComboBoxColumn author;
        private DataGridViewComboBoxColumn publisher;
        private DataGridViewButtonColumn modify;
        private DataGridViewButtonColumn delete;
    }
}