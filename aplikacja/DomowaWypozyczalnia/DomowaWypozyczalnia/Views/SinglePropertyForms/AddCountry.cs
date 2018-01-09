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
        public AddCountry() : base("Dodaj nowe państwo", AddOrEditCountry)
        { }

        public AddCountry(Country country) : base("Edytuj państwo " + country.Name, AddOrEditCountry, country)
        {
            SetComponents(country.Name);
        }

        static Tuple<Result, string> AddOrEditCountry(TextBox textBox, object obj)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                List<Country> countries = Country.GetAllWithName(textBox.Text);
                if (obj == null)
                {
                    if (countries == null || countries.Count == 0)
                    {
                        Country.InsertCountry(textBox.Text);

                        return EverythingOk;
                    }
                    else
                    {
                        return Tuple.Create(Result.InvalidInput, "Wprowadzone państwo istnieje. Nie można wykonać operacji.");
                    }
                }
                else
                {
                    if (countries == null || countries.Count == 0)
                    {
                        ((Country) obj).Name = textBox.Text;
                        Database.Submit();

                        return EverythingOk;
                    }
                    else
                    {
                        return Tuple.Create(Result.InvalidInput, "Wprowadzone państwo istnieje bądź nie zostało wyedytowane. Nie można wykonać operacji.");
                    }
                }
            }
            else
            {
                return Tuple.Create(Result.InvalidInput, "Nie wypełniłeś pola Nazwa. Nie można wykonać operacji");
            }
        }
    }
}
