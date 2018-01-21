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
    public partial class Carriers : Form
    {
        public Carriers()
        {
            InitializeComponent();
            dataGridView1.DataSource = Carrier.GetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCarrier a = new AddCarrier();
            a.ShowDialog();
        }
    }
}
