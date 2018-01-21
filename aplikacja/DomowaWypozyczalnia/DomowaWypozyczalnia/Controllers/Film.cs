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

        internal static Film GetWithId(int id)
        {
            return Database.Current.Films.Where(f => f.Id == id).FirstOrDefault();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
