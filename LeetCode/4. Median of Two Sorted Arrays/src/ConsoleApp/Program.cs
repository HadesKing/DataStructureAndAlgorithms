using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                ////ISet<Int32> sortedSet = new SortedSet<Int32>();
                ////sortedSet.Add(3);
                ////sortedSet.Add(1);
                ////sortedSet.Add(2);
                ////sortedSet.Add(1);


                ////ISet<Int32> hashSet = new HashSet<Int32>();
                ////hashSet.Add(3);
                ////hashSet.Add(1);
                ////hashSet.Add(2);
                ////hashSet.Add(1);

                TestCase1();
                TestCase2();
                TestCase3();
                TestCase4();
                TestCase5();
                TestCase6();
                TestCase7();
                TestCase8();
                TestCase9();
                TestCase10();
                TestCase11();
                ////TestCase1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("The End!");
        }


        private static void TestCase1()
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
            double result, expectedResult;
            int[] num1 = null;
            int[] num2 = null;

            MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
            result = medianOfTwoSortedArrays.DoAction2(num1, num2);
            expectedResult = 0;
            Console.WriteLine(result == expectedResult);
        }

        private static void TestCase2()
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
            double result, expectedResult;
            int[] num1 = new[] { 1 };
            int[] num2 = null;

            MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
            result = medianOfTwoSortedArrays.DoAction2(num1, num2);
            expectedResult = 1;
            Console.WriteLine(result == expectedResult);
        }
        private static void TestCase3()
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
            double result, expectedResult;
            int[] num1 = null;
            int[] num2 = new[] { 1 };

            MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
            result = medianOfTwoSortedArrays.DoAction2(num1, num2);
            expectedResult = 1;
            Console.WriteLine(result == expectedResult);
        }

        private static void TestCase4()
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
            double result, expectedResult;
            int[] num1 = new[] { 1 };
            int[] num2 = new[] { 1 };

            MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
            result = medianOfTwoSortedArrays.DoAction2(num1, num2);
            expectedResult = 1;
            Console.WriteLine(result == expectedResult);
        }

        private static void TestCase5()
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
            double result, expectedResult;
            List<Int32> list = new List<int>();
            int[] num2 = new[] { 1 };

            MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
            result = medianOfTwoSortedArrays.DoAction2(list.ToArray(), num2);
            expectedResult = 1;
            Console.WriteLine(result == expectedResult);
        }

        private static void TestCase6()
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
            double result, expectedResult;
            int[] num1 = new[] { 1, 2, 3 };
            int[] num2 = new[] { 1, 2, 5 };

            MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
            result = medianOfTwoSortedArrays.DoAction2(num1, num2);
            expectedResult = 2.5;
            Console.WriteLine(result == expectedResult);
        }

        private static void TestCase7()
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
            double result, expectedResult;
            Int32[] num1 = new Int32[] { 0, 0, 0, 0, 0 };
            Int32[] num2 = new Int32[] { -1, 0, 0, 0, 0, 0, 1 };

            MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
            result = medianOfTwoSortedArrays.DoAction2(num1, num2);
            expectedResult = 0;
            Console.WriteLine(result == expectedResult);
        }
        private static void TestCase8()
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
            double result, expectedResult;
            Int32[] num1 = new Int32[] { 3 };
            Int32[] num2 = new Int32[] { -2, -1 };

            MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
            result = medianOfTwoSortedArrays.DoAction2(num1, num2);
            expectedResult = -1.0D;
            Console.WriteLine(result == expectedResult);
        }
        private static void TestCase9()
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
            double result, expectedResult;
            Int32[] num1 = new Int32[] { 1 };
            Int32[] num2 = new Int32[] { 2, 3 };

            MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
            result = medianOfTwoSortedArrays.DoAction2(num1, num2);
            expectedResult = 2.0D;
            Console.WriteLine(result == expectedResult);
        }
        private static void TestCase10()
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
            double result, expectedResult;
            Int32[] num1 = new Int32[] { 4 };
            Int32[] num2 = new Int32[] { 1, 2, 3, 5, 6 };

            MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
            result = medianOfTwoSortedArrays.DoAction2(num1, num2);
            expectedResult = 3.5D;
            Console.WriteLine(result == expectedResult);
        }
        private static void TestCase11()
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
            double result, expectedResult;
            Int32[] num1 = new Int32[] { 4 };
            Int32[] num2 = new Int32[] { 1, 2, 3 };

            MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
            result = medianOfTwoSortedArrays.DoAction2(num1, num2);
            expectedResult = 2.5D;
            Console.WriteLine(result == expectedResult);
        }

    }
}
