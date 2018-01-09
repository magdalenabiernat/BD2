using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowaWypozyczalnia
{
    public enum Result
    {
        Ok, EmptyImput, InvalidInput, InvalidPassword,
        ResultConflict, ResultCannotBeDeleted, ResultDirtyContext,
        DuplicatedValue, UnchangedValue
    }
}
