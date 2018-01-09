using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomowaWypozyczalnia
{
    public partial class AddRole : AddSingleProperty
    {
        public AddRole() 
            : base("Dodaj nową rolę", AddOrEditRole)
        { }

        public AddRole(Role role)
            : base("Edytuj rolę " + role.Name, AddOrEditRole, role)
        {
            SetComponents(role.Name);
        }

        static Result AddOrEditRole(TextBox textBox, object obj)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                List<Role> roles = Role.GetAllWithName(textBox.Text);
                if(obj == null)
                {
                    if (roles == null || roles.Count == 0)
                    {
                        Role.InsertRole(textBox.Text);
                        return Result.Ok;
                    }
                    else
                        return Result.DuplicatedValue;
                }
                else
                {
                    if (roles == null || roles.Count == 0)
                    {
                        ((Role)obj).Name = textBox.Text;
                        Database.Submit();
                        return Result.Ok;
                    }
                    else
                        return Result.UnchangedValue;
                }
            }
            else
                return Result.EmptyImput;
        }
    }
}
