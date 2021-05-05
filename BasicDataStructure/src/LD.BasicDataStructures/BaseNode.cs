using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

namespace LD.BasicDataStructures
{
    /// <summary>
    /// 双向链表 节点 实体
    /// </summary>
    /// <typeparam name="T">数据 类型</typeparam>
    public abstract class BaseNode<T>
    {


        /// <summary>
        /// 数据
        /// </summary>
        public virtual T Data { get; set; }
        
        /// <summary>
        /// Returns a string that represents the current object.
        /// (Inherited from Object)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Data?.ToString();
        }

    }
}
