using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;

namespace UniversalValidator
{
    public static class Numbers
    {
  
        //For all numeric inputs
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

        //For all integers inputs
        public static bool isInt(string input)
        {
            int i;
            bool b = int.TryParse(input, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out i);
            if (b)
            {
                return true;
            }
            return false;
        }

        //For all Float inputs
        public static bool isFloat(string input)
        {
            float f;
            bool b = float.TryParse(input, out f);
            if (b)
                return true;

            return false;
        }
    }
}
