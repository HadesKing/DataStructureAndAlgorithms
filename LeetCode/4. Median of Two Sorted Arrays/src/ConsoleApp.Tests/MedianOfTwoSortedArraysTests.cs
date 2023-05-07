using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Tests
{
    [TestClass()]
    public class MedianOfTwoSortedArraysTests
    {
        [TestMethod()]
        public void DoActionTest()
        {
            double result, expectedResult;

            //test case 1
            int[] num1 = null;
            int[] num2 = null;

            MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
            result = medianOfTwoSortedArrays.DoAction(num1, num2);
            expectedResult = 0;

            Assert.IsTrue(result == expectedResult);

            num1 = new[] { 1 };
            num2 = null;
            result = medianOfTwoSortedArrays.DoAction(num1, num2);
            expectedResult = 1;

            Assert.IsTrue(result == expectedResult);

        }
    }
}