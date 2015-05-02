using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniversalValidatorUT
{
    [TestClass]
    public class NumbersValidationTests
    {
        //TESTS FOR ALL NUMERIC
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


        //TESTS FOR ALL INTEGERS
        [TestMethod]
        public void ValidateIfInputIsIntegerFail()
        {
            string input = "A21";
            bool pass = UniversalValidator.Numbers.IsInt(input);
            Assert.IsFalse(pass);
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
            string input = "11200000,34555,443456";
            bool pass = UniversalValidator.Numbers.IsNumeric(input);
            Assert.IsTrue(pass);
        }

        [TestMethod]
        public void ValidateIfInputIsIntegerSucceed()
        {
            string input = "2,147,483,647";
            bool pass = UniversalValidator.Numbers.IsInt(input);
            Assert.IsTrue(pass);
        }


        //TESTS FOR ALL FLOATS
        [TestMethod]
        public void ValidateIfInputIsFloatFail()
        {
            string input = "0A";
            bool pass = UniversalValidator.Numbers.IsFloat(input);
            Assert.IsFalse(pass);
        }

        [TestMethod]
        public void ValidateIfInputIsFloatSucceed()
        {
            string input = "1.063E-02";
            bool pass = UniversalValidator.Numbers.IsFloat(input);
            Assert.IsTrue(pass);
        }


        //TESTS FOR ALL BIGINTEGERS
        [TestMethod]
        public void ValidateIfInputIsBigIntegerFail()
        {
            string input = "A+5";
            bool pass = UniversalValidator.Numbers.IsBigInteger(input);
            Assert.IsFalse(pass);
        }

        [TestMethod]
        public void ValidateIfInputIsBigIntegerSucceed()
        {
            string input = "9223372036854775808";
            bool pass = UniversalValidator.Numbers.IsBigInteger(input);
            Assert.IsTrue(pass);
        }


        //TESTS FOR ALL DECIMALS
        [TestMethod]
        public void ValidateIfInputIsDecimalFail()
        {
            string input = "ABv3";
            bool pass = UniversalValidator.Numbers.IsDecimal(input);
            Assert.IsFalse(pass);
        }

        [TestMethod]
        public void ValidateIfInputIsDecimalSucceed()
        {
            string input = "80.0";
            bool pass = UniversalValidator.Numbers.IsDecimal(input);
            Assert.IsTrue(pass);
        }

        //TESTS FOR ALL INFINITE INPUTS
        [TestMethod]
        public void ValidateIfInputIsInfiniteSucceed() {
            string input = "56978/0";
            bool pass = UniversalValidator.Numbers.IsInfinity(input);
            Assert.IsTrue(pass);
        }

        [TestMethod]
        public void ValidateIfInputIsInfiniteFail() {
            string input = "50/5";
            bool pass = UniversalValidator.Numbers.IsInfinity(input);
            Assert.IsFalse(pass);
        }
    }
}
