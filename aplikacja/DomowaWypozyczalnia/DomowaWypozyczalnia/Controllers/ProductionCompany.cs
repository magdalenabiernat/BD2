using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowaWypozyczalnia
{
    partial class ProductionCompany
    {
        internal static List<ProductionCompany> GetAllWithName(string name)
        {
            return Database.Current.ProductionCompanies
                .Where(c => c.Name.ToLower() == name.ToLower())
                .ToList();
        }

        internal static void InsertCompany(string name)
        {
            ProductionCompany company = new ProductionCompany() { Name = name };
            Database.Current.ProductionCompanies.InsertOnSubmit(company);
            Database.Submit();
        }
    }
}
