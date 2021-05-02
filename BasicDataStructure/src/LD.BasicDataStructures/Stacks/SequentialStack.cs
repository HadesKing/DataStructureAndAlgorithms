using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

namespace LD.BasicDataStructures.Stacks
{
    /// <summary>
    /// Implementation of sequential stack
    /// </summary>
    /// <typeparam name="T">Type of data</typeparam>
    public sealed class SequentialStack<T> : IStack<SequentialNode<T>> where T : class
    {
        private SequentialNode<T>[] m_sequentialNodes = null;
        private Int32 m_dataElementNumber = 0;

        /// <summary>
        /// 构造函数
        /// </summary>
        public SequentialStack() : this(10)
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="capacity">Stack capacity</param>
        public SequentialStack(Int32 capacity)
        {
            m_sequentialNodes = new SequentialNode<T>[capacity];
        }

        /// <summary>
        /// Gets the number of elements contained in the Stack.
        /// </summary>
        public int Count => m_dataElementNumber;

        /// <summary>
        /// Verify that it is empty.
        /// </summary>
        /// <returns>
        /// <c>true</c> Is empty.
        /// <c>false</c> Not is empty.
        /// </returns>
        public bool IsEmpty()
        {
            return m_dataElementNumber == 0;
        }

        /// <summary>
        /// Add a data element to the stack.
        /// </summary>
        /// <param name="element">value of data element</param>
        /// <returns>
        /// <c>true</c> The operation was successful.
        /// <c>false</c> The operation failed.
        /// </returns>
        public bool Push(SequentialNode<T> element)
        {
            bool result = false;
            if (null != element)
            {
                if (m_dataElementNumber != m_sequentialNodes.Length)
                {
                    m_sequentialNodes[m_dataElementNumber] = element;
                    m_dataElementNumber++;
                    result = true;
                }
                else
                {
                    //扩容
                    var tmp = m_sequentialNodes;
                    m_sequentialNodes = new SequentialNode<T>[2 * m_dataElementNumber];
                    tmp.CopyTo(m_sequentialNodes, 0);
                    result = Push(element);
                }
            }

            return result;
        }

        /// <summary>
        /// Pop up a data element from the stack.
        /// If there is no data element in the stack, it returns null.
        /// </summary>
        /// <returns>
        /// Data element being popped.If there is no data element in the stack, it returns null.
        /// </returns>
        public SequentialNode<T> Pop()
        {
            if (0 != m_dataElementNumber)
            {
                m_dataElementNumber--;
                return m_sequentialNodes[m_dataElementNumber];
            }

            return null;
        }

        /// <summary>
        /// Get a data element from the stack.If the stack is empty, return null.
        /// </summary>
        /// <returns>
        /// Data element.If the stack is empty, return null
        /// </returns>
        public SequentialNode<T> Get()
        {
            if (0 != m_dataElementNumber)
            {
                return m_sequentialNodes[m_dataElementNumber - 1];
            }

            return null;
        }

    }
}
