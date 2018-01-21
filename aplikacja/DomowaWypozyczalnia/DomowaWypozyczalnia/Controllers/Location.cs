using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowaWypozyczalnia
{
    partial class Location
    {
        public override string ToString()
        {
            return LocationType1.Name + ": " + Place;
        }
    }
}
