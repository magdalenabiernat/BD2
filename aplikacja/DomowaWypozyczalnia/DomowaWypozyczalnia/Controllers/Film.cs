using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowaWypozyczalnia
{
    partial class Film
    {
        internal static List<Film> GetAll()
        {
            return Database.Current.Films.ToList();
        }
    }
}
