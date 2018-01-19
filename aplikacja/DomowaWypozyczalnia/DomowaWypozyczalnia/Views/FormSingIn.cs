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
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Uzupełnij dane logowania");
            }
            else
            {
                Result result = User.ValidateUser(textBoxLogin.Text, textBoxPassword.Text);
                switch (result)
                {
                    case Result.InvalidInput:
                        MessageBox.Show("Nieprawidłowy login");
                        break;
                    case Result.InvalidPassword:
                        MessageBox.Show("Nieprawidłowe hasło");
                        break;
                    case Result.Ok:
                        MainForm form = new MainForm(User.IsAdmin(textBoxLogin.Text), User.GetUser(textBoxLogin.Text));
                        Hide();
                        form.FormClosed += (s, args) => Close();
                        form.Show();
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carrier ca=new Carrier();
            AddCarrier c=new AddCarrier(ca);
            c.ShowDialog();
           
        }
    }
}
