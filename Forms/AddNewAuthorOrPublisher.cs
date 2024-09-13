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
    public partial class AddNewAuthorOrPublisher : Form
    {
        string name;
        public AddNewAuthorOrPublisher(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void AddNewAuthorOrPublisher_Load(object sender, EventArgs e)
        {
            lbName.Text += name;
            this.Text += name;
        }
    }
}
