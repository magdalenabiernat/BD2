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
    public partial class FormSignIn : Form
    {
        DataClassesWypozyczalnia db;

        public FormSignIn()
        {
            InitializeComponent();
            db = new DataClassesWypozyczalnia();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Uzupełnij dane logowania");
            }
            else
            {
                Result result = User.ValidateUser(textBoxLogin.Text, textBoxPassword.Text);

            }
        }
    }
}
