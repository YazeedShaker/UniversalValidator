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

        [TestMethod]
        public void ValidateIfInputIsNumericScientificSucceed()
        {
            string input = "1.23E+11";
            bool pass = UniversalValidator.Numbers.IsNumeric(input);
            Assert.IsTrue(pass);
        }

        [TestMethod]
        public void ValidateIfInputIsNumericRawSucceed()
        {
            string input = "234234234";
            bool pass = UniversalValidator.Numbers.IsNumeric(input);
            Assert.IsTrue(pass);
        }

        [TestMethod]
        public void ValidateIfInputIsNumericCommaSucceed()
        {
            string input = "112,345,3456";
            bool pass = UniversalValidator.Numbers.IsNumeric(input);
            Assert.IsTrue(pass);
        }

        [TestMethod]
        public void ValidateIfInputIsIntegerSucceed()
        {
            string input = "2,147,483,647";
            bool pass = UniversalValidator.Numbers.isInt(input);
            Assert.IsTrue(pass);
        }

        [TestMethod]
        public void ValidateIfInputIsFloatSucceed()
        {
            string input = "1.063E-02";
            bool pass = UniversalValidator.Numbers.isFloat(input);
            Assert.IsTrue(pass);
        }

        [TestMethod]
        public void ValidateIfInputIsBigIntegerSucceed()
        {
            string input = "9223372036854775808";
            bool pass = UniversalValidator.Numbers.isBigInteger(input);
            Assert.IsTrue(pass);
        }

        [TestMethod]
        public void ValidateIfInputIsDecimalSucceed()
        {
            string input = "80.0";
            bool pass = UniversalValidator.Numbers.isDecimal(input);
            Assert.IsTrue(pass);
        }
    }
}
