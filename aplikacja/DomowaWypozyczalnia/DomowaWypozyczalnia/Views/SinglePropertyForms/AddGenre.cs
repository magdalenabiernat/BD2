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
    public partial class AddGenre : AddSingleProperty
    {
        public AddGenre() : base("Dodaj nowy gatunek", AddOrEditGenre)
        { }

        public AddGenre(Genre genre) : base("Edytuj gatunek " + genre.Name, AddOrEditGenre, genre)
        {
            SetComponents(genre.Name);
        }

        static Tuple<Result, string> AddOrEditGenre(TextBox textBox, object obj)
        {
            if(!string.IsNullOrWhiteSpace(textBox.Text))
            {
                List<Genre> genres = Genre.GetAllWithName(textBox.Text);
                if(obj == null)
                {
                    if(genres == null || genres.Count == 0)
                    {
                        Genre.InsertGenre(textBox.Text);

                        return EverythingOk;
                    }
                    else
                    {
                        return Tuple.Create(Result.InvalidInput, "Wprowadzony gatunek istnieje. Nie można wykonać operacji.");
                    }
                }
                else
                {
                    if (genres == null || genres.Count == 0)
                    {
                        ((Genre)obj).Name = textBox.Text;
                        Database.Submit();

                        return EverythingOk;
                    }
                    else
                    {
                        return Tuple.Create(Result.InvalidInput, "Wprowadzony gatunek istnieje bądź nie został wyedytowany. Nie można wykonać operacji.");
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
