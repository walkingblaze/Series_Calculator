using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Series_Calculator.Entity;
using Series_Calculator.BusinessLogic;
using Series_Calculator.HelperLibrary;

namespace SeriesCalculatorTests
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        public void Series1Test()
        {
            List<Int64> ExpectedList = new List<Int64>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            OutputResult Expected = new OutputResult();
            Expected.Result = ExpectedList;
            Expected.OutputStatus = Status.Success;

            Int64 UserInput = 20;
            OutputResult Actual = Logic.Series1(UserInput);

            List<Int64> ActualList = (List<Int64>)Actual.Result;

            Assert.AreEqual(Expected.Message, Actual.Message);
            Assert.AreEqual(Expected.OutputStatus, Actual.OutputStatus);
            CollectionAssert.AreEqual(ExpectedList, ActualList);
        }

        [TestMethod]
        public void Series2Test()
        {
            List<Int64> ExpectedList = new List<Int64>() { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            OutputResult Expected = new OutputResult();
            Expected.Result = ExpectedList;
            Expected.OutputStatus = Status.Success;

            Int64 UserInput = 20;
            OutputResult Actual = Logic.Series2(UserInput);

            List<Int64> ActualList = (List<Int64>)Actual.Result;

            Assert.AreEqual(Expected.Message, Actual.Message);
            Assert.AreEqual(Expected.OutputStatus, Actual.OutputStatus);
            CollectionAssert.AreEqual(ExpectedList, ActualList);
        }

        [TestMethod]
        public void Series3Test()
        {
            List<Int64> ExpectedList = new List<Int64>() { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            OutputResult Expected = new OutputResult();
            Expected.Result = ExpectedList;
            Expected.OutputStatus = Status.Success;

            Int64 UserInput = 20;
            OutputResult Actual = Logic.Series3(UserInput);

            List<Int64> ActualList = (List<Int64>)Actual.Result;

            Assert.AreEqual(Expected.Message, Actual.Message);
            Assert.AreEqual(Expected.OutputStatus, Actual.OutputStatus);
            CollectionAssert.AreEqual(ExpectedList, ActualList);
        }

        [TestMethod]
        public void Series4Test()
        {
            List<string> ExpectedList = new List<string>() { "Z", "1", "2", "C", "4", "E", "C", "7", "8", "C", "E", "11", "C", "13", "14", "Z", "16", "17", "C", "19", "E" };
            OutputResult Expected = new OutputResult();
            Expected.Result = ExpectedList;
            Expected.OutputStatus = Status.Success;

            Int64 UserInput = 20;
            OutputResult Actual = Logic.Series4(UserInput);

            List<string> ActualList = (List<string>)Actual.Result;

            Assert.AreEqual(Expected.Message, Actual.Message);
            Assert.AreEqual(Expected.OutputStatus, Actual.OutputStatus);
            CollectionAssert.AreEqual(ExpectedList, ActualList);
        }

        [TestMethod]
        public void Series5Test()
        {
            List<Int64> ExpectedList = new List<Int64>() { 1, 2, 3, 5, 8, 13 };
            OutputResult Expected = new OutputResult();
            Expected.Result = ExpectedList;
            Expected.OutputStatus = Status.Success;

            Int64 UserInput = 20;
            OutputResult Actual = Logic.Series5(UserInput);

            List<Int64> ActualList = (List<Int64>)Actual.Result;

            Assert.AreEqual(Expected.Message, Actual.Message);
            Assert.AreEqual(Expected.OutputStatus, Actual.OutputStatus);
            CollectionAssert.AreEqual(ExpectedList, ActualList);
        }

        

    }
}
