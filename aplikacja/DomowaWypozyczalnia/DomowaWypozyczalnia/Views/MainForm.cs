using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomowaWypozyczalnia.Views;

namespace DomowaWypozyczalnia
{
    public partial class MainForm : Form
    {
        private bool isAdmin;
        private User user;

        public MainForm(bool isAdmin, User user)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.user = user;
            SwitchPanel();
        }

        private void SwitchPanel()
        {
            if (isAdmin)
            {
                panelAdmin.Visible = true;
                SetAdminPanel();
            }
            else
            {
                panelUser.Visible = true;
                SetUserPanel();
            }
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGenre ag = new AddGenre();
            ag.Show();
        }

        private void SetAdminPanel()
        {
            labelAdmin.Text += user.Inmate1.Name;
        }

        private void SetUserPanel()
        {
            labelUser.Text += user.Inmate1.Name;
        }

        private void buttonATitles_Click(object sender, EventArgs e)
        {
            ShowTitles title = new ShowTitles();
            title.ShowDialog();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            ShowUsers u = new ShowUsers();
            u.ShowDialog();
        }

        private void buttonCarries_Click(object sender, EventArgs e)
        {
            Carriers c = new Carriers();
            c.ShowDialog();
        }

        private void buttonAFilms_Click(object sender, EventArgs e)
        {
            Films f = new Films();
            f.ShowDialog();
        }

        private void buttonAHires_Click(object sender, EventArgs e)
        {
            Hires h = new Hires();
            h.ShowDialog();
        }
    }
}
