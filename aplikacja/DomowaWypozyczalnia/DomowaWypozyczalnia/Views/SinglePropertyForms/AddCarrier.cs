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
    public partial class AddCarrier : AddSingleProperty
    {
        public AddCarrier() : base("Dodaj nowy nośnik", AddOrEditCarrier)
        { }

        public AddCarrier(Carrier carrier) : base("Edytuj nośnik " + carrier.Name, AddOrEditCarrier, carrier)
        {
            SetComponents(carrier.Name);
        }

        static Tuple<Result, string> AddOrEditCarrier(TextBox textBox, object obj)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                List<Carrier> carriers = Carrier.GetAllWithName(textBox.Text);
                if (obj == null)
                {
                    if (carriers == null || carriers.Count == 0)
                    {
                        Carrier.InsertCarrier(textBox.Text);

                        return EverythingOk;
                    }
                    else
                    {
                        return Tuple.Create(Result.InvalidInput, "Wprowadzony nośnik istnieje. Nie można wykonać operacji.");
                    }
                }
                else
                {
                    if (carriers == null || carriers.Count == 0)
                    {
                        ((Carrier)obj).Name = textBox.Text;
                        Database.Submit();

                        return EverythingOk;
                    }
                    else
                    {
                        return Tuple.Create(Result.InvalidInput, "Wprowadzony nośnik istnieje bądź nie został wyedytowany. Nie można wykonać operacji.");
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
