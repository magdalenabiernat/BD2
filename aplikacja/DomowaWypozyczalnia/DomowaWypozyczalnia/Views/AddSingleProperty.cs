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
    public abstract partial class AddSingleProperty : Form
    {
        public delegate Tuple<Result, string> MyDelegate(TextBox t, object o);

        private MyDelegate myDelegate;
        private object obj = null;

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
