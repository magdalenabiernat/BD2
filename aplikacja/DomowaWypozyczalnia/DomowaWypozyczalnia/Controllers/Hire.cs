using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowaWypozyczalnia
{
    partial class Hire
    {
        internal static List<Hire> GetAll()
        {
            return Database.Current.Hires.Where(h => h.Returned == false).ToList();
        }
    }
}
