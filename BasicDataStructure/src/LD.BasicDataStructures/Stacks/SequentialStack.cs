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

        public SequentialStack(Int32 capacity)
        {
            m_sequentialNodes = new SequentialNode<T>[capacity];
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public bool Push(SequentialNode<T> element)
        {
            throw new NotImplementedException();
        }

        public SequentialNode<T> Pop()
        {
            throw new NotImplementedException();
        }

        public SequentialNode<T> Get()
        {
            throw new NotImplementedException();
        }
    }
}
