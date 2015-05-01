using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace UniversalValidator
{
    public static class Numbers
    {
  
        //For all numeric inputs
        public static bool IsNumeric(string input)
        {
            return Regex.IsMatch(input, @"^[-+]?[0-9]*\.?(,[0-9]+)?[0-9]+([eE][-+]?[0-9]+)?$");
        }

        //For all integer inputs
        public static bool isInt(string input)
        {
            int i;
            bool b = Int32.TryParse(input, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out i);
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

        //For all BigInteger inputs
        public static bool isBigInteger(string input)
        {
            BigInteger big = new BigInteger();
            bool b = BigInteger.TryParse(input, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out big);
            if (b)
                return true;
            return false;
        }

        //For all Decimal inputs
        public static bool isDecimal(string input)
        {
            decimal d;
            bool b = Decimal.TryParse(input, out d);
            if (isBigInteger(input))
                return false;
            else if(b)
                return true;
            return false;
        }
    }
}
