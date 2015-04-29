using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniversalValidatorUT
{
    [TestClass]
    public class IntegersValidationTests
    {

        [TestMethod]
        public void ValidateIfInputIsIntegerSucceed()
        {
            string input = "2,147,483,647";
            bool pass = UniversalValidator.validateInt.isInt(input);
            Assert.IsTrue(pass);
        }

    }
}
