using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowaWypozyczalnia
{
    partial class User
    {
        public static Result ValidateUser(string username, string password)
        {
            GetUser(username);
            return Result.Ok;
        }

        private static void GetUser(string username)
        {
            User user = Database.Current.Users.Where(u => u.Login == username).FirstOrDefault();
        }
    }
}
