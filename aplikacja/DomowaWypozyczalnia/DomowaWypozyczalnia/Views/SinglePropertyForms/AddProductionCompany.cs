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
    public partial class AddProductionCompany : AddSingleProperty
    {
        public AddProductionCompany() 
            : base("Dodaj wytwórnię filmową",AddOrEditProductionCompany)
        { }

        public AddProductionCompany(ProductionCompany company)
            : base("Edytuj wytwórnię " + company.Name, AddOrEditProductionCompany, company)
        {
            SetComponents(company.Name);
        }

         static Result AddOrEditProductionCompany(TextBox textBox, object obj)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                List<ProductionCompany> companies = ProductionCompany.GetAllWithName(textBox.Text); 
            }
            else
                return Result.EmptyImput;
        }
    }
}
