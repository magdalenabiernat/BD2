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
            User user = GetUser(username);
            if (user == null)
                return Result.InvalidInput;

            if (user.Active == false)
                return Result.InvalidInput;

            if (user.HashedPassword == AesCryptography.EncryptString(password))
                return Result.Ok;
            else
                return Result.InvalidPassword;
        }

        public static User GetUser(string username)
        {
            return Database.Current.Users.Where(u => u.Login == username).FirstOrDefault();
        }

        public static bool IsAdmin(string username)
        {
            return Database.Current.Users.Where(u => u.Login == username).FirstOrDefault().Admin;
        }

        public static void InsertUser(User user)
        {
            if (user != null)
            {
                Database.Current.Users.InsertOnSubmit(user);
                Database.Submit();
            }     
        }
    }
}
