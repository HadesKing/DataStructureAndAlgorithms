using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"{Math.Pow(10,2)}");

                Int32[] array = new Int32[]
                {
                    2,7,11,15,7
                };
                TwoSum twoSum = new TwoSum();
                // Tuple<Int32, Int32> result = twoSum.DoAction(array, 6);

                // Console.WriteLine($"Index1 = {result.Item1}, Index2 = {result.Item2}");
                
                Int32[] result = twoSum.DoAction(array, 9);
                Console.WriteLine($"Index1 = {result[0].ToString()}, Index2 = {result[1].ToString()}");

                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("The End!");
        }
    }
}
