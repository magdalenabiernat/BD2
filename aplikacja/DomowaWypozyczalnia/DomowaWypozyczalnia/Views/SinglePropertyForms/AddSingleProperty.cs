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
        public delegate Tuple<Result, string> MyDelegate(TextBox t, object o);

        private MyDelegate myDelegate;
        protected object obj = null;
        public static Tuple<Result, string> EverythingOk
        {
            get
            {
                return Tuple.Create(Result.Ok, "");
            }
        }

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
            if (result.Item1 == Result.Ok)
                Close();
            else
                MessageBox.Show(result.Item2);
        }
    }
}
