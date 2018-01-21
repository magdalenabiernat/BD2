using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomowaWypozyczalnia.Views
{
    public partial class Hires : Form
    {
        public Hires()
        {
            InitializeComponent();
            comboBox1.DataSource = User.GetAll();
            dataGridView1.DataSource = Hire.GetAll();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
