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
        static Country country = null;

        public AddCountry() : base("Dodaj nowe państwo", AddOrEditCountry)
        {           
        }

        public AddCountry(Country country) : base("Edytuj państwo " + country.Name, AddOrEditCountry, country)
        {
            setComponents();
        }

        private void setComponents()
        {
            if(country != null)
            {
                textBoxName.Text = country.Name;
            }
        }

        static Tuple<Result, string> AddOrEditCountry(TextBox t, Object o)
        {
            if (!string.IsNullOrWhiteSpace(t.Text))
            {
                List<Country> countries = Country.GetAllWithName(t.Text);
                if (o == null)
                {
                    if (countries == null || countries.Count == 0)
                    {
                        Country c = new Country();
                        c.Name = t.Text;
                        Database.Current.Countries.InsertOnSubmit(c);
                        Database.Submit();

                        return Tuple.Create(Result.Ok, "");
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
                        ((Country)o).Name = t.Text;
                        Database.Submit();

                        return Tuple.Create(Result.Ok, "");
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
