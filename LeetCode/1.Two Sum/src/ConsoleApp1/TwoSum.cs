
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    /// <summary>
    /// Two Sum 算法
    /// </summary>
    /// <remarks>
    /// 地址：
    /// https://leetcode-cn.com/problems/two-sum/submissions/ 
    /// </remarks>
    public class TwoSum
    {

        // 总结
        //     1. Dictionary 使用Hash进行存储，提高算法时间复杂度时，优先考虑
        //     2. for循环的循环条件尽量前置，放在for循环的外面
        //     3. if条件判断调整判断逻辑，尽可能减少代码量

        // public Tuple<Int32, Int32> DoAction(Int32[] numbs, Int32 target)
        // {
        //     Tuple<Int32, Int32> result = null;
        //     if (null != numbs && numbs.Length > 0)
        //     {
        //         Dictionary<Int32, Int32> dictionary = new Dictionary<int, int>();
        //         Int32 maxIndex = numbs.Length - 1;
        //         for(int index = 0; index < maxIndex; index++)
        //         {

        //             if(dictionary.ContainsKey(numbs[index]))
        //             {
        //                 result = new Tuple<int, int>(dictionary[numbs[index]], index);
        //                 break;
        //             }
        //             else
        //             {
        //                 dictionary.Add(target - numbs[index], index);
        //             }
        //         }

        //     }
        //     return result;
        // }

        // /// <summary>
        // /// Solution 1 : 虽然解决了问题，但是消耗时间比较长
        // /// 312 ms	31.7 MB
        // /// </summary>
        // /// <param name="nums"></param>
        // /// <param name="target"></param>
        // /// <returns></returns>
        // public int[] DoAction(int[] nums, int target)
        // {
        //     List<Int32>  result = new List<Int32>();
        //     if (null != nums && nums.Length > 0)
        //     {
        //         Dictionary<Int32, Int32> dictionary = new Dictionary<int, int>();
        //         Int32 maxIndex = nums.Length - 1;
        //         for(int index = 0; index <= maxIndex; index++)
        //         {

        //             if(dictionary.ContainsKey(nums[index]))
        //             {
        //                 result.Add(dictionary[nums[index]]);
        //                 result.Add(index);
        //                 break;
        //             }
        //             else
        //             {
        //                 dictionary.Add(target - nums[index], index);
        //             }
        //         }

        //     }
        //     return result.ToArray();
        // }

        // /// <summary>
        // /// Solution 2 : 消耗时间有减少，但使用的内存增加了
        // /// 292 ms	31.9 MB
        // /// </summary>
        // /// <param name="nums"></param>
        // /// <param name="target"></param>
        // /// <returns></returns>
        // public int[] DoAction(int[] nums, int target)
        // {
        //     List<Int32>  result = new List<Int32>();
        //     if (null != nums && nums.Length > 0)
        //     {
        //         Dictionary<Int32, Int32> dictionary = new Dictionary<int, int>();
        //         for(int index = 0; index < nums.Length; index++)      //修改内容
        //         {
        //             if(dictionary.ContainsKey(nums[index]))
        //             {
        //                 result.Add(dictionary[nums[index]]);
        //                 result.Add(index);
        //                 break;
        //             }
        //             else
        //             {
        //                 dictionary.Add(target - nums[index], index);
        //             }
        //         }

        //     }
        //     return result.ToArray();
        // }

        // /// <summary>
        // /// Solution 3 : 消耗时间有减少，但使用的内存不变
        // /// 284 ms	31.9 MB
        // /// </summary>
        // /// <param name="nums"></param>
        // /// <param name="target"></param>
        // /// <returns></returns>
        // public int[] DoAction(int[] nums, int target)
        // {
        //     List<Int32>  result = new List<Int32>();
        //     if (null != nums && nums.Length > 0)
        //     {
        //         Dictionary<Int32, Int32> dictionary = new Dictionary<int, int>();
        //         int index = 0;  //修改内容
        //         for(; index < nums.Length; index++)
        //         {

        //             if(dictionary.ContainsKey(nums[index]))
        //             {
        //                 result.Add(dictionary[nums[index]]);
        //                 result.Add(index);
        //                 break;
        //             }
        //             else
        //             {
        //                 dictionary.Add(target - nums[index], index);
        //             }
        //         }

        //     }
        //     return result.ToArray();
        // }


        // /// <summary>
        // /// Solution 4 : 消耗时间有减少，但使用的内存不变
        // /// 276 ms	31.9 MB
        // /// </summary>
        // /// <param name="nums"></param>
        // /// <param name="target"></param>
        // /// <returns></returns>
        // public int[] DoAction(int[] nums, int target)
        // {
        //     List<Int32> result = new List<Int32>();
        //     if (null != nums && nums.Length > 0)
        //     {
        //         Dictionary<Int32, Int32> dictionary = new Dictionary<int, int>();
        //         Int32 index = 0;
        //         for (; index < nums.Length; index++)
        //         {
        //             //修改条件判断顺序
        //             if (!dictionary.ContainsKey(nums[index]))
        //             {
        //                 dictionary.Add(target - nums[index], index);
        //             }
        //             else
        //             {
        //                 result.Add(dictionary[nums[index]]);
        //                 result.Add(index);
        //                 break;
        //             }
        //         }

        //     }
        //     return result.ToArray();
        // }

        // /// <summary>
        // /// Solution 5 : 消耗时间有减少，但使用的内存不变
        // /// 276 ms	31.9 MB
        // /// </summary>
        // /// <param name="nums"></param>
        // /// <param name="target"></param>
        // /// <returns></returns>
        // public int[] DoAction(int[] nums, int target)
        // {
        //     List<Int32> result = new List<Int32>();
        //     if (null != nums && nums.Length > 0)
        //     {
        //         Dictionary<Int32, Int32> dictionary = new Dictionary<int, int>();
        //         Int32 index = 0, end = nums.Length;     //修改内容
        //         //将for替换为while内存减少，但执行时间增加，所以这里仍然是for
        //         for(; index < end; index++)
        //         {
        //             if(!dictionary.ContainsKey(nums[index]))
        //             {
        //                 dictionary.Add(target - nums[index], index);
        //             }
        //             else if(nums[index] != dictionary[nums[index]])
        //             {
        //                 result.Add(dictionary[nums[index]]);
        //                 result.Add(index);
        //             } 
        //         }

        //     }
        //     return result.ToArray();
        // }

        /// <summary>
        /// Solution 6 : LeetCode上是一个相对时间，需要多测几次
        /// 280 ms	31.9 MB
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] DoAction(int[] nums, int target)
        {
            List<Int32> result = new List<Int32>();
            if (null != nums && nums.Length > 0)
            {
                Dictionary<Int32, Int32> dictionary = new Dictionary<int, int>();
                Int32 index = 0, end = nums.Length;
                for(; index < end; index++)
                {
                    if(dictionary.ContainsKey(nums[index]))
                    {
                        result.Add(dictionary[nums[index]]);
                        result.Add(index);
                        break;
                    }
                    dictionary.Add(target - nums[index], index);
                }
                
            }
            return result.ToArray();
        }



    }
}