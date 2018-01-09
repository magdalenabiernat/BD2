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
    public partial class AddSingleProperty : Form
    {
        public delegate Result MyDelegate(TextBox t, object o);

        private MyDelegate myDelegate;
        protected object obj = null;

        private AddSingleProperty() { }

        public AddSingleProperty(string name, MyDelegate function, object o)
        {
            InitializeComponent();
            Name = name;
            myDelegate += function;
            obj = o;
        }

        public AddSingleProperty(string name, MyDelegate function)
        {
            InitializeComponent();
            Name = name;
            myDelegate += function;
        }

        protected void SetComponents(string text)
        {
            if (obj != null)
            {
                textBoxName.Text = text;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var result = myDelegate.Invoke(textBoxName, obj);
            switch(result)
            {
                case Result.Ok:
                    Close();
                    break;
                case Result.EmptyImput:
                    MessageBox.Show("Nie wypełniłeś pola Nazwa. Nie można wykonać operacji");
                    break;
                case Result.UnchangedValue:
                    MessageBox.Show("Wprowadzona Nazwa istnieje lub nie została wyedytowana. Nie można wykonać operacji.");
                    break;
                case Result.DuplicatedValue:
                    MessageBox.Show("Wprowadzona Nazwa już istnieje. Nie można wykonać operacji");
                    break;
            }                
        }
    }
}
