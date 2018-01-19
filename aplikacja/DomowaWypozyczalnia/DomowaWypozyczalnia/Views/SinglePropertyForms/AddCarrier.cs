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
    public partial class AddCarrier : AddSingleProperty
    {
        List<Carrier> carriers;
        public AddCarrier() 
            : base("Dodaj nowy nośnik", AddOrEditCarrier)
        { }

        public AddCarrier(Carrier carrier) 
            : base("Edytuj nośnik " + carrier.Name, AddOrEditCarrier, carrier)
        {
            SetComponents(carrier.Name);
        }

        static Result AddOrEditCarrier(TextBox textBox, object obj)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                List<Carrier> carriers = Carrier.GetAllWithName(textBox.Text);
                if (obj == null)
                {
                    if (carriers == null || carriers.Count == 0)
                    {
                        Carrier.InsertCarrier(textBox.Text);
                        return Result.Ok;
                    }
                    else
                        return Result.DuplicatedValue;
                }
                else
                {
                    if (carriers == null || carriers.Count == 0)
                    {
                        ((Carrier)obj).Name = textBox.Text;
                        Database.Submit();
                        return Result.Ok;
                    }
                    else
                        return Result.UnchangedValue;
                }
            }
            else
                return Result.EmptyImput;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Carrier.InsertCarrier(comboBoxCarrier.Text);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
          
        }

        private void AddCarrier_Load(object sender, EventArgs e)
        {
            carriers = Carrier.GetAllWithName(comboBoxCarrier.Text);
        }
    }
}
