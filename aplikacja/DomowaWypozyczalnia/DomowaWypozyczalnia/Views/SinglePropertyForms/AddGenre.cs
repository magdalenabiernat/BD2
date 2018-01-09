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
        public AddGenre() 
            : base("Dodaj nowy gatunek", AddOrEditGenre)
        { }

        public AddGenre(Genre genre) 
            : base("Edytuj gatunek " + genre.Name, AddOrEditGenre, genre)
        {
            SetComponents(genre.Name);
        }

        static Result AddOrEditGenre(TextBox textBox, object obj)
        {
            if(!string.IsNullOrWhiteSpace(textBox.Text))
            {
                List<Genre> genres = Genre.GetAllWithName(textBox.Text);
                if(obj == null)
                {
                    if(genres == null || genres.Count == 0)
                    {
                        Genre.InsertGenre(textBox.Text);
                        return Result.Ok;
                    }
                    else
                        return Result.DuplicatedValue;
                }
                else
                {
                    if (genres == null || genres.Count == 0)
                    {
                        ((Genre) obj).Name = textBox.Text;
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
