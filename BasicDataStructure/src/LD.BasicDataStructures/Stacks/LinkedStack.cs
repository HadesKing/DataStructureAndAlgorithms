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
    /// Implementation of chain storage stack
    /// </summary>
    /// <typeparam name="T">Type of data</typeparam>
    public sealed class LinkedStack<T> : IStack<SinglyLinkedNode<T>> where T : class
    {

        private SinglyLinkedNode<T> m_topNode = null;
        private Int32 m_count = 0;

        /// <summary>
        /// Gets the number of elements contained in the Stack.
        /// </summary>
        public Int32 Count => m_count;

        public LinkedStack()
        {

        }

        /// <summary>
        /// Verify that it is empty.
        /// </summary>
        /// <returns>
        /// <c>true</c> Is empty.
        /// <c>false</c> Not is empty.
        /// </returns>
        public bool IsEmpty()
        {
            return null == m_topNode;
        }

        /// <summary>
        /// Add a data element to the stack.
        /// </summary>
        /// <param name="element">value of data element</param>
        /// <returns>
        /// <c>true</c> The operation was successful.
        /// <c>false</c> The operation failed.
        /// </returns>
        public bool Push(SinglyLinkedNode<T> element)
        {
            bool result = false;
            if (null != element)
            {
                if (null == m_topNode)
                {
                    m_topNode = element;
                }
                else
                {
                    var tmpNode = m_topNode;
                    element.Next = tmpNode;
                    m_topNode = element;
                }

                m_count++;
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Pop up a data element from the stack.If there is no data element in the stack, it returns null.
        /// </summary>
        /// <returns>
        /// Data element being popped.If there is no data element in the stack, it returns null.
        /// </returns>
        public SinglyLinkedNode<T> Pop()
        {
            SinglyLinkedNode<T> returnNode = null;
            if (null != m_topNode)
            {
                returnNode = m_topNode;
                m_topNode = returnNode.Next;
                m_count--;
            }

            return returnNode;
        }

        /// <summary>
        /// Get a data element from the stack.If the stack is empty, return null.
        /// </summary>
        /// <returns>
        /// Data element.If the stack is empty, return null
        /// </returns>
        public SinglyLinkedNode<T> Get()
        {
            return m_topNode;
        }

    }
}
