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
   
    public partial class AddCountry : AddSingleProperty
    {
        List<Carrier> carriers;
        public AddCountry() 
            : base("Dodaj nowe państwo", AddOrEditCountry)
        { }

        public AddCountry(Country country) 
            : base("Edytuj państwo " + country.Name, AddOrEditCountry, country)
        {
            SetComponents(country.Name);
        }

        static Result AddOrEditCountry(TextBox textBox, object obj)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                List<Country> countries = Country.GetAllWithName(textBox.Text);
                if (obj == null)
                {
                    if (countries == null || countries.Count == 0)
                    {
                        Country.InsertCountry(textBox.Text);
                        return Result.Ok;
                    }
                    else
                        return Result.DuplicatedValue;
                }
                else
                {
                    if (countries == null || countries.Count == 0)
                    {
                        ((Country)obj).Name = textBox.Text;
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

        private void buttonAddCountry_Click(object sender, EventArgs e)
        {
            Country.InsertCountry(textBoxAddCountry.Text);
        }
    }
}
