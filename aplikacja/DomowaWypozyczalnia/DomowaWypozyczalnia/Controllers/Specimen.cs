using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowaWypozyczalnia
{
    partial class Specimen
    {
        internal static List<Specimen> GetActive()
        {
            return Database.Current.Specimens.Where(s => s.Active == true).ToList();
        }

        public override string ToString()
        {
            return Film1.Name + $" ({Carrier1.Name})";
        }
    }
}
