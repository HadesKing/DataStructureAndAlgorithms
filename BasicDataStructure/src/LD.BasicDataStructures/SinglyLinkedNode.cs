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
    // Create By: 刘迪
    // Create Time: 2021-04-30
    // 

    /// <summary>
    /// 单向链表 节点 实体
    /// </summary>
    /// <typeparam name="T">数据 类型</typeparam>
    public sealed class SinglyLinkedNode<T> : BaseNode<T>
    {
        /// <summary>
        /// 下一个 节点
        /// </summary>
        public SinglyLinkedNode<T> Next { get; set; }

    }
}
