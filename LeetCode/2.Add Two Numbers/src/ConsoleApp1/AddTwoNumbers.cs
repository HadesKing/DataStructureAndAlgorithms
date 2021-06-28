using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /**
     *
     * 地址：
     *     https://leetcode-cn.com/problems/add-two-numbers/solution/liang-shu-xiang-jia-by-leetcode-solution/
     *
     * 犯错：
     *     1. 对于题目理解不够清晰（通过查看答案后才知道）
     *     2. 思维不够严谨（通过测试用例来模拟各种场景，让代码写作思维严谨。也可以通过查看别人的解题思路来理解题目）
     *
     * 总结：
     *     解题思路
     *     1. 理解题目
     *     2. 找到解决方案
     *     3. 设计测试用例
     *     4. 编码
     *     5. 使用测试用例进行测试
     */

    public sealed class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

    }
    public sealed class AddTwoNumbers
    {
        public ListNode DoAction(ListNode l1, ListNode l2)
        {
            Int32 carry = 0, ten = 10, v1 = 0, v2 = 0;
            ListNode firstNode = null, currentNode = null, l1Next = l1, l2Next = l2;
            bool isContinue = (null != l1Next || null != l2Next);

            while (isContinue)
            {
                v1 = l1Next?.val ?? 0;
                v2 = l2Next?.val ?? 0;
                if ((v1 + v2 + carry) / ten >= 0)
                {
                    carry = (v1 + v2 + carry) / ten;
                }

                l1Next = l1Next?.next;
                l2Next = l2Next?.next;
                isContinue = (null != l1Next || null != l2Next);
                if (null == firstNode)
                {
                    if (isContinue || carry > 0)
                    {
                        currentNode = new ListNode(carry, null);
                    }
                    firstNode = new ListNode((v1 + v2) % ten, currentNode);
                }
                else
                {
                    currentNode.val = (v1 + v2 + currentNode.val) % ten;
                    if (isContinue)
                    {
                        currentNode.next = new ListNode(carry, null);
                        currentNode = currentNode.next;
                    }
                    else
                    {
                        currentNode.next = carry > 0 ? new ListNode(carry, null) : null;
                    }
                }
            }

            return firstNode;
        }

    }

}