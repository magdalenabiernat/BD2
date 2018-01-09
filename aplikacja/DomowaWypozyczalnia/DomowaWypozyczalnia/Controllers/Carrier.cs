using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowaWypozyczalnia
{
    partial class Carrier
    {
        internal static List<Carrier> GetAllWithName(string name)
        {
            return Database.Current.Carriers.Where(c => c.Name.ToLower() == name.ToLower()).ToList();
        }

        internal static void InsertCarrier(string name)
        {
            Carrier carrier = new Carrier() { Name = name };
            Database.Current.Carriers.InsertOnSubmit(carrier);
            Database.Submit();
        }
    }
}
