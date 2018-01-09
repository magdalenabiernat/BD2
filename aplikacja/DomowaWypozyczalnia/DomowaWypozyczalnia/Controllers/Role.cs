using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowaWypozyczalnia
{
    partial class Role
    {
        internal static List<Role> GetAllWithName(string name)
        {
            return Database.Current.Roles
                .Where(r => r.Name.ToLower() == name.ToLower())
                .ToList();
        }

        internal static void InsertRole(string name)
        {
            Role role = new Role() { Name = name };
            Database.Current.Roles.InsertOnSubmit(role);
            Database.Submit();
        }
    }
}
