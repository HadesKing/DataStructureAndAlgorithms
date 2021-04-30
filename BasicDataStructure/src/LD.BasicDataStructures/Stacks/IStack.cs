// Copyright (c) 刘迪. All rights reserved.
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

namespace LD.BasicDataStructures.Stacks
{
    /// <summary>
    /// 栈的接口 
    /// </summary>
    /// <remarks>
    /// 主要用于定义栈的公共操作
    /// </remarks>
    public interface IStack
    {

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
        /// <typeparam name="T">type of data element</typeparam>
        /// <param name="element">value of data element</param>
        /// <returns>
        /// <c>true</c> The operation was successful.
        /// <c>false</c> The operation failed.
        /// </returns>
        bool Push<T>(T element) where T : class;

        /// <summary>
        /// Pop up a data element from the stack.
        /// </summary>
        /// <typeparam name="T">type of data element</typeparam>
        /// <returns>
        /// Data element being popped.
        /// </returns>
        T Pop<T>() where T : class;

        /// <summary>
        /// Get a data element from the stack.If the stack is empty, return null.
        /// </summary>
        /// <typeparam name="T">type of data element</typeparam>
        /// <returns>
        /// Data element.If the stack is empty, return null
        /// </returns>
        T Get<T>() where T : class;


    }
}
