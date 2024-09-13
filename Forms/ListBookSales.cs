using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Manager.Forms
{
    public partial class ListBookSales : Form
    {
        public ListBookSales()
        {
            InitializeComponent();
        }

        private void SáchMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewBook addNewBookForm = new AddNewBook();
            addNewBookForm.ShowDialog();
        }

        private void TácGiảMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewAuthorOrPublisher newAddAuthorOrPublisherForm = new AddNewAuthorOrPublisher("tác giả");
            newAddAuthorOrPublisherForm.ShowDialog();
        }

        private void NhàXuấtBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewAuthorOrPublisher newAddAuthorOrPublisherForm = new AddNewAuthorOrPublisher("nhà xuất bản");
            newAddAuthorOrPublisherForm.ShowDialog();
        }
    }
}
