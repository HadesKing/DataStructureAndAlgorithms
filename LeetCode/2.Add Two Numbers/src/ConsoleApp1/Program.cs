using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Test1();
                Test2();
                Test3();
                Test4();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void Test1()
        {
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));

            AddTwoNumbers addTwoNumbers = new AddTwoNumbers();
            ListNode result = addTwoNumbers.DoAction(l1, l2);

            while (null != result)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }

            Console.WriteLine("------------------The End!------------------");
        }
        private static void Test2()
        {
            ListNode l1 = new ListNode(0, null);
            ListNode l2 = new ListNode(0, null);

            AddTwoNumbers addTwoNumbers = new AddTwoNumbers();
            ListNode result = addTwoNumbers.DoAction(l1, l2);

            while (null != result)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }

            Console.WriteLine("------------------The End!------------------");
        }

        private static void Test3()
        {
            ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, null)))))));
            ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, null))));

            AddTwoNumbers addTwoNumbers = new AddTwoNumbers();
            ListNode result = addTwoNumbers.DoAction(l1, l2);

            while (null != result)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }

            Console.WriteLine("------------------The End!------------------");
        }
        private static void Test4()
        {
            ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, null)))))));
            ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, null))));

            AddTwoNumbers addTwoNumbers = new AddTwoNumbers();
            ListNode result = addTwoNumbers.DoAction(l1, l2);

            while (null != result)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }

            Console.WriteLine("------------------The End!------------------");
        }

    }
}
