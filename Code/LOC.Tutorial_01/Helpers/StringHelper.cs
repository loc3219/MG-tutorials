using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOC.Tutorial_01.Helpers
{
    public static class StringHelper
    {
        public static string MyTruncate(this string orig, int lengh)
        {
            return orig;//.Truncate(lengh);
        }
    }
}
