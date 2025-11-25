using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum SqlErrorCode
    {
        UniqueConstraint = 2627,
        UniqueIndex = 2601,
        ForeignKeyViolation = 547,
        CheckConstraint = 547,
        Timeout = -2
    }


}
