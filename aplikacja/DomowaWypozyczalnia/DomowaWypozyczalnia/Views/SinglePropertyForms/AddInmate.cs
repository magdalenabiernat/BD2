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
    public partial class AddInmate : AddSingleProperty
    {
        public AddInmate() : base("Dodaj nowego lokatora", AddOrEditInmate)
        { }

        public AddInmate(Inmate inmate) : base("Edytuj lokatora " + inmate.Name, AddOrEditInmate, inmate)
        {
            SetComponents(inmate.Name);
        }

        static Tuple<Result, string> AddOrEditInmate(TextBox textBox, object obj)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                List<Inmate> inmates = Inmate.GetAllWithName(textBox.Text);
                if (obj == null)
                {
                    if (inmates == null || inmates.Count == 0)
                    {
                        Inmate.InsertInmate(textBox.Text);

                        return EverythingOk;
                    }
                    else
                    {
                        return Tuple.Create(Result.InvalidInput, "Wprowadzony lokator istnieje. Nie można wykonać operacji.");
                    }
                }
                else
                {
                    if (inmates == null || inmates.Count == 0)
                    {
                        ((Inmate)obj).Name = textBox.Text;
                        Database.Submit();

                        return EverythingOk;
                    }
                    else
                    {
                        return Tuple.Create(Result.InvalidInput, "Wprowadzony lokator istnieje bądź nie został wyedytowany. Nie można wykonać operacji.");
                    }
                }
            }
            else
            {
                return Tuple.Create(Result.InvalidInput, "Nie wypełniłeś pola Nazwa. Nie można wykonać operacji");
            }
        }
    }
}
