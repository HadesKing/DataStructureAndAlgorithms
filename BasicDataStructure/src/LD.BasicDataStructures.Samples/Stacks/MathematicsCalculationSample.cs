using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LD.BasicDataStructures.Stacks;

/* =============================================================================
 * Copyright (c) 刘迪. All rights reserved.
 *
 * Author: 刘迪
 * Create Time: 2021-05-02
 * Description: xxx
 *
 * ==========================================================
 *
 * Modifier: xxx
 * Modifier time: xxx
 * Description: xxx
 *
 * ==========================================================
 *
 * Modifier: xxx
 * Modifier time: xxx
 * Description: xxx
 * 
 * =============================================================================
 */

namespace LD.BasicDataStructures.Samples.Stacks
{
    /// <summary>
    /// 数学计算 示例
    /// </summary>
    public sealed class MathematicsCalculationSample : ISample
    {
        private IStack<SinglyLinkedNode<String>> m_mathematicalOperationSymbolsStack = new LinkedStack<String>();

        /// <summary>
        /// 构造函数
        /// </summary>
        public MathematicsCalculationSample()
        {

        }

        /// <summary>
        /// 入栈
        /// </summary>
        /// <param name="expression"></param>
        private void PushToStack(String expression)
        {
            m_mathematicalOperationSymbolsStack.Push(new SinglyLinkedNode<string>() { Data = expression.ToString() });
        }

        /// <summary>
        /// 从栈中获取数学符号
        /// </summary>
        /// <param name="charExpression">数学符号</param>
        /// <returns></returns>
        private String GetExpressionFromStack(char charExpression)
        {
            #region [算法原理]
            // 中缀表达式转后缀表达式
            // 规则
            // 转换过程需要用到栈，具体过程如下：
            // 1）如果遇到操作数，我们就直接将其输出。
            // 2）如果遇到操作符，则我们将其放入到栈中，遇到左括号时我们也将其放入栈中。
            // 3）如果遇到一个右括号，则将栈元素弹出，将弹出的操作符输出直到遇到左括号为止。注意，左括号只弹出并不输出。
            // 4）如果遇到任何其他的操作符，如（“+”， “*”，“（”）等
            //      ，从栈中弹出元素（同等级的元素）直到遇到发现更低优先级的元素(或者栈为空)为止。
            //      弹出完这些元素后，才将遇到的操作符压入到栈中。
            //      有一点需要注意，只有在遇到" ) "的情况下我们才弹出" ( "，其他情况我们都不会弹出" ( "。
            // 5）如果我们读到了输入的末尾，则将栈中所有元素依次弹出。 
            #endregion

            StringBuilder sbExpression = new StringBuilder();
            SinglyLinkedNode<String> tmpNode = null;
            switch (charExpression)
            {
                case '(':   //优先级：最高
                    PushToStack(charExpression.ToString());
                    break;
                case '*':   //优先级：中等
                case '/':
                    tmpNode = m_mathematicalOperationSymbolsStack.Get();
                    //遇到相同等级的也要执行出栈操作（低优先级的则不执行） //tmpNode.Data != "+" && tmpNode.Data != "-")
                    while (null != tmpNode && tmpNode.Data != "(" && (tmpNode.Data == "*" || tmpNode.Data == "/"))
                    {
                        sbExpression.Append(tmpNode.Data);
                        m_mathematicalOperationSymbolsStack.Pop();
                        tmpNode = m_mathematicalOperationSymbolsStack.Get();
                    }
                    PushToStack(charExpression.ToString());     //将遇到的操作符压入到栈中
                    break;
                case '+':   //优先级：最低
                case '-':
                    tmpNode = m_mathematicalOperationSymbolsStack.Get();
                    //遇到相同等级的也要执行出栈操作
                    while (null != tmpNode && tmpNode.Data != "(" )     
                    {
                        sbExpression.Append(tmpNode.Data);
                        m_mathematicalOperationSymbolsStack.Pop();
                        tmpNode = m_mathematicalOperationSymbolsStack.Get();
                    }
                    PushToStack(charExpression.ToString());     //将遇到的操作符压入到栈中
                    break;
                case ')':
                    tmpNode = m_mathematicalOperationSymbolsStack.Get();
                    while (null != tmpNode)
                    {
                        if (tmpNode.Data == "(")
                        {
                            m_mathematicalOperationSymbolsStack.Pop();
                            break;
                        }
                        else
                        {
                            sbExpression.Append(tmpNode.Data);
                            m_mathematicalOperationSymbolsStack.Pop();
                            tmpNode = m_mathematicalOperationSymbolsStack.Get();
                        }
                    }
                    break;
            }
            return sbExpression.ToString();
        }
        /// <summary>
        /// 进行数字操作的元素的之间的分隔符
        /// </summary>
        private Char m_split = '?';
        /// <summary>
        /// 中缀表达式转换成后缀表达式
        /// </summary>
        /// <param name="argMathematicsExpression">数学表达式</param>
        /// <returns></returns>
        private String InfixExpressionConvertToPostfixExpression(String argMathematicsExpression)
        {
            StringBuilder sbExpression = new StringBuilder();
            if (!String.IsNullOrWhiteSpace(argMathematicsExpression))
            {
                String mathematicsExpression = argMathematicsExpression.Replace(" ", "");
                Int32 length = mathematicsExpression.Length;
                for (Int32 i = 0; i < length; i++)
                {
                    char charExpression = mathematicsExpression[i];
                    //这里考虑到多个字符
                    if (Char.IsNumber(charExpression))
                    {
                        sbExpression.Append(charExpression.ToString());
                    }
                    else
                    {
                        sbExpression.Append(m_split.ToString());
                        sbExpression.Append(GetExpressionFromStack(charExpression));
                    }
                }
                //将剩余的数学运算符出栈
                if (!m_mathematicalOperationSymbolsStack.IsEmpty())
                {
                    while (m_mathematicalOperationSymbolsStack.Count > 0)
                    {
                        sbExpression.Append(m_mathematicalOperationSymbolsStack.Pop().ToString());
                    }

                }
            }

            return sbExpression.ToString();
        }

        private Int32 GetValueFromPostfixExpression(String postfixExpression)
        {
            IStack<SequentialNode<Int32>>  stack = new SequentialStack<Int32>();

            Int32 length = postfixExpression.Length;
            StringBuilder sbElement = new StringBuilder();
            for (Int32 i = 0; i < length; i++)
            {
                Char tmpCharExpression = postfixExpression[i];
                //方法一（当前实现）
                //判断是否是操作数之间的分隔符，如果是则将之前的字符串认为是一个操作数（例如：110）
                //方法二
                //也可以通过栈中的元素*10，相加之和再入栈
                if (m_split.Equals(tmpCharExpression))
                {
                    if (!String.IsNullOrWhiteSpace(sbElement.ToString()))
                    {
                        stack.Push(
                            new SequentialNode<Int32>() { Data = Int32.Parse(sbElement.ToString()) }
                        );
                        sbElement = new StringBuilder();
                    }
                    continue;
                }
                //当出现运算符时，弹出栈里面的数字进行运算
                if (Char.IsNumber(tmpCharExpression))
                {
                    sbElement.Append(tmpCharExpression.ToString());
                }
                else if (stack.Count > 0)
                {
                    SequentialNode<Int32> node1 = stack.Pop();
                    SequentialNode<Int32> node2 = stack.Pop();
                    Int32 result = 0;
                    switch (tmpCharExpression)
                    {
                        case '+':
                            result = node2.Data + node1.Data;
                            break;
                        case '-':
                            result = node2.Data - node1.Data;
                            break;
                        case '*':
                            result = node2.Data * node1.Data;
                            break;
                        case '/':
                            if (0 == node1.Data)
                            {
                                throw new Exception("Zero cannot be used as a divisor.");
                            }
                            result = node2.Data / node1.Data;
                            break;
                    }
                    stack.Push(new SequentialNode<Int32>() { Data = result });
                }
                
            }

            return stack.Pop().Data;
        }

        public void Sample()
        {
            //由简入繁，逐步进行校验算法（构造不同的场景）
            String mathematicsExpression = "121+10*(53-49+20)/((35-25)*2+10)";
            String expression = InfixExpressionConvertToPostfixExpression(mathematicsExpression);
            Int32 result = GetValueFromPostfixExpression(expression);
        }
    }
}
