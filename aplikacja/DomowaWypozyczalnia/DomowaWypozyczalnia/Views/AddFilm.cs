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
    public partial class AddFilm : Form
    {
        public AddFilm()
        {
            Genre genre = new Genre();
            comboBoxGenre.DataSource = Genre.GetAll();
            dataGridViewFilms.DataSource = Film.GetAll();
            InitializeComponent();
        }

        private void buttonAddFilm_Click(object sender, EventArgs e)
        {
            if (textBoxDuration.Text != "" && dateTimePickerProductionDate.Value != null)
                Film.InsertFilm(textBoxName.Text, Int32.Parse(comboBoxGenre.Text), dateTimePickerProductionDate.Value, Int32.Parse(textBoxProductionCompany.Text), Int32.Parse(textBoxDuration.Text));
            else
                MessageBox.Show("Wypełnij wszystkie wymagane pola");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditFilm(textBoxName, dataGridViewFilms);
        }
        internal static void EditFilm(TextBox textBox, DataGridView dataGridView)
        {
            List<Film> films = Film.GetAllWithName(textBox.Text);
            DataGridViewRow row;
            row = dataGridView.SelectedRows[0];
            var id = Int32.Parse(row.Cells[0].Value.ToString());
        }
    }
}
