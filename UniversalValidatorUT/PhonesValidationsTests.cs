using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniversalValidatorUT
{
    [TestClass]
    public class PhonesValidationsTests
    {
        [TestMethod]
        public void ValidateIfInputNonPhoneFails()
        {
            string nonePhone = "2832ksjd2";
            bool pass = UniversalValidator.Phones.IsPhone(nonePhone);
            Assert.IsFalse(pass);
        }

        [TestMethod]
        public void ValidateIfInputPhoneSucceeds()
        {
            string nonePhone = "641-233-8694";
            bool pass = UniversalValidator.Phones.IsPhone(nonePhone);
            Assert.IsTrue(pass);
        }
    }
}
