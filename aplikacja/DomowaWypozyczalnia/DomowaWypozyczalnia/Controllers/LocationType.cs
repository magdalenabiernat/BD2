using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowaWypozyczalnia
{
    partial class LocationType
    {
        internal static List<LocationType> GetAllWithName(string name)
        {
            return Database.Current.LocationTypes
                .Where(l => l.Name.ToLower() == name.ToLower())
                .ToList();
        }

        internal static void InsertLocationType(string name)
        {
            LocationType type = new LocationType() { Name = name };
            Database.Current.LocationTypes.InsertOnSubmit(type);
            Database.Submit();
        }
    }
}
