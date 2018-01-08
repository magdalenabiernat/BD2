using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomowaWypozyczalnia.Controllers
{
    public partial class AddCountry : Form
    {
        Country country = null;

        public AddCountry(Country country = null)
        {
            InitializeComponent();
            this.country = country;
        }

        private void setComponents()
        {
            if(country != null)
            {
                this.Name = "Edytuj państwo";
                textBoxCountry.Text = country.Name;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var result = AddOrEditCountry();
            if (result.Item1 == Result.Ok)
                Close();
            else
                MessageBox.Show(result.Item2);
        }

        private Tuple<Result,string> AddOrEditCountry()
        {
            if (!string.IsNullOrWhiteSpace(textBoxCountry.Text))
            {
                List<Country> countries = Country.GetAllWithName(textBoxCountry.Text);
                if (country == null)
                {
                    if (countries == null || countries.Count == 0)
                    {
                        Country c = new Country();
                        c.Name = textBoxCountry.Text;
                        Database.Current.Countries.InsertOnSubmit(c);
                        Database.Submit();

                        return Tuple.Create(Result.Ok,"");
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
                        country.Name = textBoxCountry.Text;
                        Database.Submit();

                        return Tuple.Create(Result.Ok,"");
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
