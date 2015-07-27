using System;
using System.Collections.Generic;
using ConsoleApplication2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApplication2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            NumsDivBy3and5 oNumsDivBy3and5 = new NumsDivBy3and5() { iNums = 100 };

            //Act
            System.Collections.Generic.List<String> ExpectedResult = GetExpectedResult();
            System.Collections.Generic.List<String> Result = oNumsDivBy3and5.NumDivs();

            //Assert
            Assert.AreEqual(ExpectedResult.ToString(), Result.ToString());
        }

        public List<String> GetExpectedResult()
        {
            System.Collections.Generic.List<String> ExpectedResult = new System.Collections.Generic.List<String> {  "1",
                                                                "2",
                                                                "3: Ficc",
                                                                "4",
                                                                "5: Buzz",
                                                                "6: Ficc",
                                                                "7",
                                                                "8",
                                                                "9: Ficc",
                                                                "10: Buzz",
                                                                "11",
                                                                "12: Ficc",
                                                                "13",
                                                                "14",
                                                                "15: Ficc, Buzz",
                                                                "16",
                                                                "17",
                                                                "18: Ficc",
                                                                "19",
                                                                "20: Buzz",
                                                                "21: Ficc",
                                                                "22",
                                                                "23",
                                                                "24: Ficc",
                                                                "25: Buzz",
                                                                "26",
                                                                "27: Ficc",
                                                                "28",
                                                                "29",
                                                                "30: Ficc, Buzz",
                                                                "31",
                                                                "32",
                                                                "33: Ficc",
                                                                "34",
                                                                "35: Buzz",
                                                                "36: Ficc",
                                                                "37",
                                                                "38",
                                                                "39: Ficc",
                                                                "40: Buzz",
                                                                "41",
                                                                "42: Ficc",
                                                                "43",
                                                                "44",
                                                                "45: Ficc, Buzz",
                                                                "46",
                                                                "47",
                                                                "48: Ficc",
                                                                "49",
                                                                "50: Buzz",
                                                                "51: Ficc",
                                                                "52",
                                                                "53",
                                                                "54: Ficc",
                                                                "55: Buzz",
                                                                "56",
                                                                "57: Ficc",
                                                                "58",
                                                                "59",
                                                                "60: Ficc, Buzz",
                                                                "61",
                                                                "62",
                                                                "63: Ficc",
                                                                "64",
                                                                "65: Buzz",
                                                                "66: Ficc",
                                                                "67",
                                                                "68",
                                                                "69: Ficc",
                                                                "70: Buzz",
                                                                "71",
                                                                "72: Ficc",
                                                                "73",
                                                                "74",
                                                                "75: Ficc, Buzz",
                                                                "76",
                                                                "77",
                                                                "78: Ficc",
                                                                "79",
                                                                "80: Buzz",
                                                                "81: Ficc",
                                                                "82",
                                                                "83",
                                                                "84: Ficc",
                                                                "85: Buzz",
                                                                "86",
                                                                "87: Ficc",
                                                                "88",
                                                                "89",
                                                                "90: Ficc, Buzz",
                                                                "91",
                                                                "92",
                                                                "93: Ficc",
                                                                "94",
                                                                "95: Buzz",
                                                                "96: Ficc",
                                                                "97",
                                                                "98",
                                                                "99: Ficc",
                                                                "100: Buzz"};
            return ExpectedResult;
        }
    }
}
