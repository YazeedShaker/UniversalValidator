using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalValidator
{
    public static class Floats
    {
        public static bool isFloat(string input)
        {
            float f;
            bool b = float.TryParse(input,out f);
            if (b)
                return true;

            return false;
        }

    }
}
