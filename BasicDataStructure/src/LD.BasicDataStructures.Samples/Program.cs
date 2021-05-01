using System;
using System.Collections.Generic;
using LD.BasicDataStructures.Samples.Stacks;

namespace LD.BasicDataStructures.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                IList<ISample> samples = new List<ISample>();
                samples.Add(new SequentialStackSample());
                samples.Add(new LinkedStackSample());

                foreach (var tmp in samples)
                {
                    tmp.Sample();
                }

                Console.WriteLine("Success");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("The End!");
        }
    }
}
