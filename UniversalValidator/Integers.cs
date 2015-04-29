using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace UniversalValidator
{
    public static class Integers
    {
        public static bool isInt(string input)
        {
            int i;
            bool b = int.TryParse(input, NumberStyles.AllowThousands,CultureInfo.InvariantCulture,out i);
            if (b)
            {
                return true;
            }
            return false;
        }

    }
}
