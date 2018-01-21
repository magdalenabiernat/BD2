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
    public partial class ShowTitles : Form
    {
        public ShowTitles()
        {
            InitializeComponent();
            dataGridViewTitles.DataSource = Film.GetAll();
        }

        private void dataGridViewTitles_Click(object sender, EventArgs e)
        {
            if (dataGridViewTitles.SelectedRows.Count > 0)
                MessageBox.Show("coś");
        }
    }
}
