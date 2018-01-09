using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DomowaWypozyczalnia
{
    partial class Country
    {
        internal static List<Country> GetAllWithName(string name)
        {
            return Database.Current.Countries.Where(c => c.Name.ToLower() == name.ToLower()).ToList();
        }

        internal static void InsertCountry(string name)
        {
            Country country = new Country() { Name = name };
            Database.Current.Countries.InsertOnSubmit(country);
            Database.Submit();
        } 
    }
}
