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
    public partial class AddLocationType : AddSingleProperty
    {
        public AddLocationType()
            : base("Dodaj nowy typ lokalizacji", AddOrEditLocationType)
        { }

        public AddLocationType(LocationType type)
            : base("Edytuj typ " + type.Name, AddOrEditLocationType, type)
        {
            SetComponents(type.Name);
        }

        static Result AddOrEditLocationType(TextBox textBox, object obj)
        {
            if(!string.IsNullOrWhiteSpace(textBox.Text))
            {
                List<LocationType> types = LocationType.GetAllWithName(textBox.Text);
                if(obj == null)
                {
                    if (types == null || types.Count == 0)
                    {
                        LocationType.InsertLocationType(textBox.Text);
                        return Result.Ok;
                    }
                    else
                        return Result.DuplicatedValue;
                }
                else
                {
                    if (types == null || types.Count == 0)
                    {
                        ((LocationType)obj).Name = textBox.Text;
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
