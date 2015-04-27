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
            int i;
            double d;
            float f;
            decimal de;
            long l;
            BigInteger big = new BigInteger();
            bool isNumeric = true;
   
            if (int.TryParse(input, out i))
            {
                return isNumeric;
            }
            else if (double.TryParse(input, out d))
            {
                return isNumeric;
            }
            else if (float.TryParse(input, out f))
            {
                return isNumeric;
            }
            else if (decimal.TryParse(input, out de))
            {
                return isNumeric;
            }
            else if (long.TryParse(input, out l))
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
