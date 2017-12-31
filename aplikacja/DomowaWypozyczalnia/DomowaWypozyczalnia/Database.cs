using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowaWypozyczalnia
{
    internal static class Database
    {
        private static DataClassesWypozyczalnia database;

        public static DataClassesWypozyczalnia Current
        {
            get
            {
                if (database == null)
                    database = new DataClassesWypozyczalnia();
                return database;
            }
        }

        public static void Refresh()
        {
            database = new DataClassesWypozyczalnia();
        }

        public static Result Submit()
        {
            var result = Result.Ok;
            try
            {
                database.SubmitChanges();
            }
            catch(ChangeConflictException)
            {
                result = Result.ResultConflict;
            }
            catch(System.Data.SqlClient.SqlException)
            {
                result = Result.ResultCannotBeDeleted;
            }
            catch(Exception)
            {
                result = Result.ResultDirtyContext;
            }
            return result;
        }
    }
}
