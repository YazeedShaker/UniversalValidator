using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace UniversalValidator
{
    public static class Numbers
    {
  

        public static bool IsNumeric(string input)
        {
            double d;
            decimal de;
            BigInteger big = new BigInteger();
            bool isNumeric = true;

            if (decimal.TryParse(input, out de))
            {
                return isNumeric;
            }
            else if (double.TryParse(input, out d))
            {
                return isNumeric;
            }
            else if (BigInteger.TryParse(input, out big))
            {
                return isNumeric;
            }

            return false;
        }
    }
}
