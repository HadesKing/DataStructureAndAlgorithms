using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LD.BasicDataStructures.Stacks;

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

namespace LD.BasicDataStructures.Samples.Stacks
{
    public sealed class LinkedStackSample : ISample
    {
        public void Sample()
        {
            IStack<SinglyLinkedNode<String>> stack = new LinkedStack<String>();

            Int32 cycleNumber = 10;
            Int32 popNumber = cycleNumber / 2;
            SinglyLinkedNode<String> tmpSequentialNode = null;
            for (Int32 i = 0; i < cycleNumber; i++)
            {
                stack.Push(new SinglyLinkedNode<String>()
                {
                    Data = i.ToString()
                });
                if (i >= popNumber)
                {
                    stack.Pop();
                }
                else
                {
                    tmpSequentialNode = stack.Get();
                    Console.WriteLine($"SinglyLinkedNode data is 【{tmpSequentialNode.Data}】");
                }
            }

            Console.WriteLine($"【{MethodBase.GetCurrentMethod().DeclaringType.FullName}】 end.");
        }
    }
}
