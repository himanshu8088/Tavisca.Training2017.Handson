using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentRecord;

namespace TestStudentRecord
{
    [TestClass]
    public class TestValidation
    {
        #region Name(First Name and Last name) Test Cases
        [TestMethod]
        public void IsValidLetter_NameValid_True()
        {
            bool response = Validation.IsValidLetter("Logan");
            Assert.IsTrue(response);
        }

        [TestMethod]
        public void IsValidLetter_NameValid_False()
        {
            bool response = Validation.IsValidLetter("Logan Lokhandwale");
            Assert.IsFalse(response);
        }

        [TestMethod]
        public void IsValidLetter_NameInvalidIntialLetter_False()
        {
            bool response = Validation.IsValidLetter("logan");
            Assert.IsFalse(response);
        }

        [TestMethod]
        public void IsValidLetter_NameSpecialCharacterCheck_False()
        {
            bool response = Validation.IsValidLetter("@/logan");
            Assert.IsFalse(response);
        }
        #endregion


        #region  Mobile Test Cases
        [TestMethod]
        public void IsValidNumber_MobileNumberValid_True()
        {
            string num = "9988776655";
            bool response = Validation.IsValidNumber(int.Parse(num));
            Assert.IsTrue(response);
        }

        [TestMethod]
        public void IsValidNumber_MobileNumberLargerLength_NotAccepted()
        {
            string num = "99888888888655";
            bool response = Validation.IsValidNumber(int.Parse(num));
            Assert.IsFalse(response);
        }

        [TestMethod]
        public void IsValidNumber_MobileNumberLesserLength_NotAccepted()
        {
            string num = "998855";
            bool response = Validation.IsValidNumber(int.Parse(num));
            Assert.IsFalse(response);
        }
        #endregion

        #region
        [TestMethod]
        public void IsValidEmail_InvalidString_NotAccepted()
        {            
            bool response = Validation.IsValidEmail("*&4532@asd.%sad");
            Assert.IsFalse(response);
        }
        [TestMethod]
        public void IsValidEmail_InvalidInitial_NotAccepted()
        {
            bool response = Validation.IsValidEmail("#@tva.com");
            Assert.IsFalse(response);
        }
        [TestMethod]
        public void IsValidEmail_MissingDomainRegister_NotAccepted()
        {
            bool response = Validation.IsValidEmail("#@tva");
            Assert.IsFalse(response);
        }
        #endregion


    }
}
