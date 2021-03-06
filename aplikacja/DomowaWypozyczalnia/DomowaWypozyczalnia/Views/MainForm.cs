﻿using System;
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
                panelAdmin.Visible = true;
            else
                panelUser.Visible = true;    
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
    }
}
