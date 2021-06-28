using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestSample1();
                TestSample2();
                TestSample3();
                TestSample4();
                TestSample5();
                TestSample6();
                TestSample7();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void TestSample1()
        {
            String s = "abcabcbb";
            LongestSubstringWithoutRepeatingCharacters longestSubstringWithoutRepeatingCharacters = new LongestSubstringWithoutRepeatingCharacters();
            Int32 result = longestSubstringWithoutRepeatingCharacters.DoAction(s);
            Int32 expectedResult = 3;

            Console.WriteLine(result == expectedResult);
        }
        private static void TestSample2()
        {
            String s = "bbbbb";
            LongestSubstringWithoutRepeatingCharacters longestSubstringWithoutRepeatingCharacters = new LongestSubstringWithoutRepeatingCharacters();
            Int32 result = longestSubstringWithoutRepeatingCharacters.DoAction(s);
            Int32 expectedResult = 1;

            Console.WriteLine(result == expectedResult);
        }
        private static void TestSample3()
        {
            String s = "pwwkew";
            LongestSubstringWithoutRepeatingCharacters longestSubstringWithoutRepeatingCharacters = new LongestSubstringWithoutRepeatingCharacters();
            Int32 result = longestSubstringWithoutRepeatingCharacters.DoAction(s);
            Int32 expectedResult = 3;

            Console.WriteLine(result == expectedResult);
        }
        private static void TestSample4()
        {
            String s = "";
            LongestSubstringWithoutRepeatingCharacters longestSubstringWithoutRepeatingCharacters = new LongestSubstringWithoutRepeatingCharacters();
            Int32 result = longestSubstringWithoutRepeatingCharacters.DoAction(s);
            Int32 expectedResult = 0;

            Console.WriteLine(result == expectedResult);
        }
        private static void TestSample5()
        {
            String s = " ";
            LongestSubstringWithoutRepeatingCharacters longestSubstringWithoutRepeatingCharacters = new LongestSubstringWithoutRepeatingCharacters();
            Int32 result = longestSubstringWithoutRepeatingCharacters.DoAction(s);
            Int32 expectedResult = 1;

            Console.WriteLine(result == expectedResult);
        }
        private static void TestSample6()
        {
            String s = "dvdf";
            LongestSubstringWithoutRepeatingCharacters longestSubstringWithoutRepeatingCharacters = new LongestSubstringWithoutRepeatingCharacters();
            Int32 result = longestSubstringWithoutRepeatingCharacters.DoAction(s);
            Int32 expectedResult = 3;

            Console.WriteLine(result == expectedResult);
        }

        private static void TestSample7()
        {
            String s = "abba";
            LongestSubstringWithoutRepeatingCharacters longestSubstringWithoutRepeatingCharacters = new LongestSubstringWithoutRepeatingCharacters();
            Int32 result = longestSubstringWithoutRepeatingCharacters.DoAction(s);
            Int32 expectedResult = 2;

            Console.WriteLine(result == expectedResult);
        }
    }
}
