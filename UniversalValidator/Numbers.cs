﻿using System;
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
            return Regex.IsMatch(input, @"^[+-]?(\d+|(\d+,)+)(\.)?\d+?([Ee][+-]?\d+)?$");
        }

        //For all integer inputs
        public static bool IsInt(string input)
        {
            int i;
            return Int32.TryParse(input, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out i);
        }

        //For all Float inputs
        public static bool IsFloat(string input)
        {
            float f;
            return float.TryParse(input, out f);
        }

        //For all BigInteger inputs
        public static bool IsBigInteger(string input)
        {
            BigInteger big = new BigInteger();
            return BigInteger.TryParse(input, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out big);
        }

        //For all Decimal inputs
        public static bool IsDecimal(string input)
        {
            decimal d;
            bool b = Decimal.TryParse(input, out d); 
            if (IsBigInteger(input))
                return false;
            else if(b)
                return true;
            return false;
        }

        //For all infinty inputs
        public static bool IsInfinity(string input)
        {
            double d;
            Double.TryParse(input, out d);
            if (Double.IsInfinity(d) || Double.IsNaN(d))
                return true;
            return Regex.IsMatch(input, @"^(\d*/0|0/0)$");
            return false;
        }

        //For all Long inputs
        public static bool IsLong(string input){
            return Regex.IsMatch(input, @"^[+-]?(\d+|(\d+,)+)\d+?([Ee][+-]?\d+)?$");
        }

        //For all Short inputs
        public static bool IsShort(string input)
        {
            short s;
            return short.TryParse(input,NumberStyles.AllowThousands,CultureInfo.InvariantCulture, out s);
        }
    }
}
