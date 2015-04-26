using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniversalValidatorUT
{
    [TestClass]
    class PhonesValidationsTests
    {
        [TestMethod]
        public void ValidateIfInputNonPhoneFails()
        {
            string nonePhone = "2832ksjd2";
            bool pass = UniversalValidator.Phones.IsPhone(nonePhone);

            Assert.IsFalse(pass);
        }
    }
}
