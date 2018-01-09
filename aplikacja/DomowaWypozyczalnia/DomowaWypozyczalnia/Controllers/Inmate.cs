using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowaWypozyczalnia
{
    partial class Inmate
    {
        internal static List<Inmate> GetAllWithName(string name)
        {
            return Database.Current.Inmates.Where(i => i.Name.ToLower() == name.ToLower()).ToList();
        }

        internal static void InsertInmate(string name)
        {
            Inmate inmate = new Inmate() { Name = name };
            Database.Current.Inmates.InsertOnSubmit(inmate);
            Database.Submit();
        }
    }
}
