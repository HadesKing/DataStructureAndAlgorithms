using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LD.BasicDataStructures.Stacks;

// Copyright (c) 刘迪. All rights reserved.
//
// Author: 刘迪
// Create Time: 2021-05-02
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
    /// <summary>
    /// 数学计算 示例
    /// </summary>
    public sealed class MathematicsCalculationSample : ISample
    {
        private IStack<SinglyLinkedNode<String>> m_mathematicalOperationSymbolsStack = new LinkedStack<String>();

        public MathematicsCalculationSample()
        {

        }
        private void PushToStack(String expression)
        {
            m_mathematicalOperationSymbolsStack.Push(new SinglyLinkedNode<string>() { Data = expression.ToString() });
        }

        // 中缀表达式转后缀表达式
        // 规则
        // 转换过程需要用到栈，具体过程如下：
        // 1）如果遇到操作数，我们就直接将其输出。
        // 2）如果遇到操作符，则我们将其放入到栈中，遇到左括号时我们也将其放入栈中。
        // 3）如果遇到一个右括号，则将栈元素弹出，将弹出的操作符输出直到遇到左括号为止。注意，左括号只弹出并不输出。
        // 4）如果遇到任何其他的操作符，如（“+”， “*”，“（”）等，从栈中弹出元素直到遇到发现更低优先级的元素(或者栈为空)为止。
        //      弹出完这些元素后，才将遇到的操作符压入到栈中。
        //      有一点需要注意，只有在遇到" ) "的情况下我们才弹出" ( "，其他情况我们都不会弹出" ( "。
        // 5）如果我们读到了输入的末尾，则将栈中所有元素依次弹出。

        private String GetExpressionFromStack(char charExpression)
        {
            StringBuilder sbExpression = new StringBuilder();

            SinglyLinkedNode<String> tmpNode = null;
            switch (charExpression)
            {
                case '(':   //优先级最高
                    PushToStack(charExpression.ToString());
                    break;
                case '*':
                case '/':
                    tmpNode = m_mathematicalOperationSymbolsStack.Get();
                    while (null != tmpNode && tmpNode.Data != "(" && tmpNode.Data != "+" && tmpNode.Data != "-")
                    {
                        sbExpression.Append(tmpNode.Data);
                        m_mathematicalOperationSymbolsStack.Pop();
                        tmpNode = m_mathematicalOperationSymbolsStack.Get();
                    }
                    PushToStack(charExpression.ToString());     //将遇到的操作符压入到栈中
                    break;
                case '+':
                case '-':
                    tmpNode = m_mathematicalOperationSymbolsStack.Get();
                    while (null != tmpNode && tmpNode.Data != "(" && tmpNode.Data != "*" && tmpNode.Data != "/")
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

                    sbExpression.Append(Char.IsNumber(charExpression)
                        ? charExpression.ToString()
                        : GetExpressionFromStack(charExpression));
                }

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

        public void Sample()
        {
            String mathematicsExpression = "1+2+3-5+2*(6-2+5)-3";
            String expression = InfixExpressionConvertToPostfixExpression(mathematicsExpression);
        }
    }
}
