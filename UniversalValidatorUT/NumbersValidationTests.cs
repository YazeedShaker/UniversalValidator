using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniversalValidatorUT
{
    [TestClass]
    public class NumbersValidationTests
    {
        [TestMethod]
        public void ValidateIfInputIsNumbericFail()
        {
            string input = "A";
            bool pass = UniversalValidator.Numbers.IsNumeric(input);
            Assert.IsFalse(pass);
        }
    }
}
