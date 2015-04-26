using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UniversalValidator
{
    public static class Phones
    {
        public static bool IsPhone(string input)
        {
            bool isPhone = false;
            try
            {
                isPhone = Regex.IsMatch(input, @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isPhone;
        }
    }
}
