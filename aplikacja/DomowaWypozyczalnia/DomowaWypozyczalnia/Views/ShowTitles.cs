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

            dataGridViewTitles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCast.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTitles.AutoResizeColumns();

            setFilm(0);
            
        }

        private void dataGridViewTitles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTitles.SelectedCells.Count > 0)
            {
                int pos = dataGridViewTitles.SelectedCells[0].RowIndex;
                int id = (int)dataGridViewTitles.Rows[pos].Cells["idDataGridViewTextBoxColumn"].Value;

                setDataGridViewActors(Film.GetWithId(id).Casts.ToList());
                setFilm(pos);
            }
        }

        private void setDataGridViewActors(List<Cast> cast)
        {
            dataGridViewCast.DataSource = null;
            dataGridViewCast.DataSource = cast;

            dataGridViewCast.AutoResizeColumns();
            if (cast.Count != 0 && cast != null) setActor(0);
            else clearActor();
        }

        private void setActor(int pos)
        {
            textBoxPerson.Text = ((Person)dataGridViewCast.Rows[pos].Cells["person1DataGridViewTextBoxColumn"].Value).ToString();
            textBoxRole.Text = ((Role)dataGridViewCast.Rows[pos].Cells["role1DataGridViewTextBoxColumn"].Value).ToString();
            textBoxCharacter.Text = (string)dataGridViewCast.Rows[pos].Cells["characterDataGridViewTextBoxColumn"].Value;
        }

        private void clearActor()
        {
            textBoxPerson.Text = string.Empty;
            textBoxRole.Text = string.Empty;
            textBoxCharacter.Text = string.Empty;
        }

        private void setFilm(int pos)
        {
            textBoxName.Text = (string)dataGridViewTitles.Rows[pos].Cells["nameDataGridViewTextBoxColumn"].Value;
            textBoxGenre.Text = ((Genre)dataGridViewTitles.Rows[pos].Cells["genre1DataGridViewTextBoxColumn"].Value).ToString();
            textBoxDuration.Text = ((int)dataGridViewTitles.Rows[pos].Cells["durationDataGridViewTextBoxColumn"].Value).ToString();
            textBoxProductionDate.Text = ((DateTime)dataGridViewTitles.Rows[pos].Cells["productionDateDataGridViewTextBoxColumn"].Value).ToString("dd-MM-yyyy");
            textBoxCompany.Text = ((ProductionCompany)dataGridViewTitles.Rows[pos].Cells["productionCompany1DataGridViewTextBoxColumn"].Value).ToString();
        }
    }
}
