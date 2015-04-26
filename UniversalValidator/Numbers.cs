using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalValidator
{
    public static class Numbers
    {
        public static bool IsNumeric(string input)
        {
            int outValue;
            bool isNumeric = int.TryParse(input, out outValue);
            return isNumeric;
        }
    }
}
