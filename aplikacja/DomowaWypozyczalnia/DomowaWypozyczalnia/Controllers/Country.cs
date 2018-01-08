using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowaWypozyczalnia
{
    partial class Country
    {
        public static List<Country> GetAllWithName(string name)
        {
            return Database.Current.Countries.Where(c => c.Name.ToLower() == name.ToLower()).ToList();
        }
    }
}
