using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomowaWypozyczalnia
{
    public partial class ShowUsers : Form
    {
        public ShowUsers()
        {
            InitializeComponent();
            dataGridView1.DataSource = User.GetAll();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = User.GetActives();
        }
    }
}
