using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Series_Calculator.Entity;
using Series_Calculator.BusinessLogic;
using Series_Calculator.HelperLibrary;

namespace SeriesCalculatorTests
{
    [TestClass]
    public class ExtensionsTests
    {

        [TestMethod]
        public void AddUserInputReferenceStringEmptyTest()
        {
            string UserInput = "0";
            string _string = string.Empty;
            string ExpectedResult = string.Empty;

            if (string.IsNullOrEmpty(_string))
                ExpectedResult = string.Empty;
            else
                ExpectedResult = _string.Replace("@@UserInput", UserInput);

            string Actual = _string.AddUserInput(UserInput);
            Assert.AreEqual(ExpectedResult, Actual);
        }

        [TestMethod]
        public void AddUserInputReferenceStringNullTest()
        {
            string UserInput = "0";
            string _string = null;
            string ExpectedResult = string.Empty;

            if (string.IsNullOrEmpty(_string))
                ExpectedResult = string.Empty;
            else
                ExpectedResult = _string.Replace("@@UserInput", UserInput);

            string Actual = _string.AddUserInput(UserInput);
            Assert.AreEqual(ExpectedResult, Actual);
        }

        [TestMethod]
        public void AddUserInputStringEmptyTest()
        {
            string UserInput = string.Empty;
            string _string = StringConstants.Series1Label;
            string ExpectedResult = string.Empty;

            if (string.IsNullOrEmpty(UserInput))
                ExpectedResult = _string;
            else
                ExpectedResult = _string.Replace("@@UserInput", UserInput);

            string Actual = _string.AddUserInput(UserInput);
            Assert.AreEqual(ExpectedResult, Actual);
        }

        [TestMethod]
        public void AddUserInputStringNullTest()
        {
            string UserInput = null;
            string _string = StringConstants.Series1Label;
            string ExpectedResult = string.Empty;

            if (string.IsNullOrEmpty(UserInput))
                ExpectedResult = _string;
            else
                ExpectedResult = _string.Replace("@@UserInput", UserInput);

            string Actual = _string.AddUserInput(UserInput);
            Assert.AreEqual(ExpectedResult, Actual);
        }
    }
}
