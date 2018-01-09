using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowaWypozyczalnia
{
    partial class Genre
    {
        internal static List<Genre> GetAllWithName(string name)
        {
            return Database.Current.Genres.Where(g => g.Name.ToLower() == name.ToLower()).ToList();
        }

        internal static void InsertGenre(string name)
        {
            Genre genre = new Genre() { Name = name };
            Database.Current.Genres.InsertOnSubmit(genre);
            Database.Submit();
        }
    }
}
