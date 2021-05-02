using System;
using System.Collections.Generic;
using LD.BasicDataStructures.Samples.Stacks;

// Copyright (c) 刘迪. All rights reserved.
//
// Author: 刘迪
// Create Time: 2021-05-01 
//
// Modifier: xxx
// Modifier time: xxx
// Description: xxx
//
// Modifier: xxx
// Modifier time: xxx
// Description: xxx
// 
// 
//

namespace LD.BasicDataStructures.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                //String mathematicsExpression = "1+2*(2+3)";
                //Int32 length = mathematicsExpression.Length;
                //for (Int32 i = 0; i < length; i++)
                //{
                //    char expressionChar = mathematicsExpression[i];
                //    bool isNumber = Char.IsNumber(expressionChar);
                //    Console.WriteLine(isNumber);
                //}

                IList<ISample> samples = new List<ISample>();
                samples.Add(new SequentialStackSample());
                samples.Add(new LinkedStackSample());
                samples.Add(new MathematicsCalculationSample());

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
