﻿// Copyright (c) 刘迪. All rights reserved.
//
// Author: 刘迪
// Create Time: 2021-04-30
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

using System;

namespace LD.BasicDataStructures.Stacks
{
    /// <summary>
    /// 栈的接口 
    /// </summary>
    /// <typeparam name="T">type of data element</typeparam>
    /// <remarks>
    /// 主要用于定义栈的公共操作
    /// </remarks>
    public interface IStack<T>
    {
        /// <summary>
        /// Gets the number of elements contained in the Stack.
        /// </summary>
        Int32 Count { get; }

        /// <summary>
        /// Verify that it is empty.
        /// </summary>
        /// <returns>
        /// <c>true</c> Is empty.
        /// <c>false</c> Not is empty.
        /// </returns>
        bool IsEmpty();

        /// <summary>
        /// Add a data element to the stack.
        /// </summary>
        /// <param name="element">value of data element</param>
        /// <returns>
        /// <c>true</c> The operation was successful.
        /// <c>false</c> The operation failed.
        /// </returns>
        bool Push(T element);

        /// <summary>
        /// Pop up a data element from the stack.If there is no data element in the stack, it returns null.
        /// </summary>
        /// <returns>
        /// Data element being popped.If there is no data element in the stack, it returns null.
        /// </returns>
        T Pop();

        /// <summary>
        /// Get a data element from the stack.If the stack is empty, return null.
        /// </summary>
        /// <returns>
        /// Data element.If the stack is empty, return null
        /// </returns>
        T Get();

    }
}
