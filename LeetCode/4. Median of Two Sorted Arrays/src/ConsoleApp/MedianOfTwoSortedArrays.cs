using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public sealed class MedianOfTwoSortedArrays
    {

        public MedianOfTwoSortedArrays()
        {

        }

        public double DoAction(int[] nums1, int[] nums2)
        {
            //模块化、流程化
            List<int> list = new List<int>();
            // 1. 数组排序处理
            int length1 = nums1?.Length ?? 0, length2 = nums2?.Length ?? 0, start1 = 0, start2 = 0, tmpDefaultValue = 0, tmp1 = tmpDefaultValue, tmp2 = tmpDefaultValue, min = 0;
            //bool isContinue = true;

            // 1.1 所有元素入新数组
            while (true)
            {
                if (length1 > start1)
                {
                    tmp1 = nums1[start1];
                }
                else
                {
                    break;
                }

                if (length2 > start2)
                {
                    tmp2 = nums2[start2];
                }
                else
                {
                    break;
                }

                if (tmp1 > tmp2 && tmp2 != tmpDefaultValue)
                {
                    start2++;
                    min = tmp2;
                }
                else if (tmp1 != tmpDefaultValue)
                {
                    start1++;
                    min = tmp1;
                }

                if (!list.Any(x => x == min && min != tmpDefaultValue))
                {
                    list.Add(min);
                }

                //临时变量复原
                tmp1 = tmpDefaultValue;
                tmp2 = tmpDefaultValue;
            }
            //将剩余元素复制到新的数组
            if (length1 > start1) list.AddRange(nums1.Skip(start1));
            if (length2 > start2) list.AddRange(nums2.Skip(start2));

            // 2. 取中位数
            double result = 0;
            int totalNumbers = list.Count;
            if (totalNumbers > 0)
            {
                if (totalNumbers % 2 == 1)
                {
                    result = list[(totalNumbers - 1) / 2];
                }
                else
                {
                    result = ((double)list[totalNumbers / 2] + (double)list[(totalNumbers - 2) / 2]) / 2.0;
                }
            }


            return result;
        }


        public double DoAction1(int[] nums1, int[] nums2)
        {
            if (nums1?.Length < nums2?.Length)
            {
                return DoAction1(nums2, nums1);
            }

            Int32 length1 = nums1?.Length ?? 0, length2 = nums2?.Length ?? 0;

            if (length2 > 0)
            {
                Int32 left = 0, right = length1;
                // median1：前一部分的最大值
                // median2：后一部分的最小值
                int median1 = 0, median2 = 0;

                while (left <= right)
                {
                    Int32 i = (left + right) / 2, j = (length1 + length2 + 1) / 2 - i;

                    // nums_im1, nums_i, nums_jm1, nums_j 分别表示 nums1[i-1], nums1[i], nums2[j-1], nums2[j]
                    Int32 nums_im1 = (i == 0 ? Int32.MinValue : nums1[i - 1]);
                    Int32 nums_i = (i == length1 ? Int32.MaxValue : nums1[i]);
                    Int32 nums_jm1 = (j == 0 ? Int32.MinValue : nums2[j - 1]);
                    Int32 nums_j = (j == length2 ? Int32.MaxValue : nums2[j]);

                    if (nums_im1 <= nums_j)
                    {
                        median1 = Math.Max(nums_im1, nums_jm1);
                        median2 = Math.Min(nums_i, nums_j);
                        left = i + 1;
                    }
                    else
                    {
                        right = i - 1;
                    }
                }

                return (length1 + length2) % 2 == 0 ? (median1 + median2) / 2.0 : median1;
            }
            else
            {
                return length1 % 2 > 0 ? nums1[length1 / 2] : (nums1[length1 / 2] + nums1[length1 / 2 - 1]) / 2;
            }

        }


        #region 【DoAction2】

        private double DivideByTwo(Int32 num)
        {
            return (double)num / 2;
        }
        /// <summary>
        /// 场景1
        /// </summary>
        /// <returns></returns>
        private double Scenes1()
        {
            return 0.00D;
        }
        /// <summary>
        /// 场景2
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private double Scenes2(int[] array)
        {
            int length = array.Length;
            double result;
            if (length % 2 == 1)
            {
                result = array[length / 2];
            }
            else
            {
                int tmp = array[length / 2] + array[(length - 1) / 2];
                result = DivideByTwo(tmp);
            }
            return result;
        }

        /// <summary>
        /// 场景3
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private double Scenes3(int[] nums1, int[] nums2)
        {
            Int32 length1 = nums1?.Length ?? 0, length2 = nums2?.Length ?? 0;
            if (length2 > length1)
                return Scenes3(nums2, nums1);

            double result;
            //分为3个场景
            //1. nums1 所有元素值都小于 nums2，中位数就是二者数组拼接在一起之后的中位数，其中之一一定在nums1中（因为num1的长度大于num2的长度）
            if (nums1[length1 - 1] <= nums2[0])
            {
                Int32 totalLength = length1 + length2;
                if (totalLength % 2 == 1)
                {
                    result = nums1[totalLength / 2];
                }
                else
                {
                    if (length1 == totalLength / 2)
                    {
                        result = DivideByTwo(nums1[length1 - 1] + nums2[0]);
                    }
                    else
                    {
                        result = DivideByTwo(nums1[totalLength / 2] + nums1[(totalLength - 1) / 2]);
                    }
                }
            }
            //2. nums1 所有元素值都大于 nums2，中位数就是二者数组拼接在一起之后的中位数，其中之一一定在nums1中（因为num1的长度大于num2的长度）
            else if (nums1[0] > nums2[length2 - 1])
            {
                Int32 totalLength = length1 + length2;
                if (totalLength % 2 == 1)
                {
                    result = nums1[(totalLength - length2) / 2 - 1];
                }
                else
                {
                    if (length1 == totalLength / 2)
                    {
                        result = DivideByTwo(nums1[0] + nums2[length2 - 1]);
                    }
                    else
                    {
                        result = DivideByTwo(nums1[(totalLength) / 2 - length2]);
                    }
                }
            }
            else
            {
                //思路，两个数据分开寻找，找到最大的索引，符合指定的条件
                result = GetMedian(nums1, nums2);
                ////使用二分查找查找中位数所在位置
                //Int32 left = 0, right = length1, median1 = 0, median2 = 0;
                //while (left <= right)
                //{
                //    Int32 i = (left + right) / 2;
                //    Int32 j = (length1 + length2 + 1) / 2 - i;

                //    if (i < 0) i = 0;
                //    if (j < 0) j = 0;

                //    Int32 num1_i_1 = i == 0 ? Int32.MinValue : nums1[i - 1];
                //    Int32 num1_i = i == length1 ? Int32.MaxValue : nums1[i];
                //    Int32 num2_j_1 = j == 0 ? Int32.MinValue : nums2[j - 1];
                //    Int32 num2_j = j == length2 ? Int32.MaxValue : nums2[j];

                //    if (num1_i_1 > num2_j)
                //    {
                //        right = i - 1;
                //    }
                //    else
                //    {
                //        left = i + 1;
                //    }

                //    if (num1_i_1 <= num2_j && num2_j_1 <= num1_i)
                //    {
                //        median1 = num1_i_1 >= num2_j_1 ? num1_i_1 : num2_j_1;       //取其最大
                //        median2 = num1_i <= num2_j ? num1_i : num2_j;     //取其最小
                //    }
                //}
                //result = (length1 + length2) % 2 == 0 ? (median1 + median2) / 2.0D : median1;
            }
            return result;
        }

        private double GetMedian(int[] nums1, int[] nums2)
        {
            double result = 0D;
            Int32 length1 = nums1.Length, length2 = nums2.Length;
            Int32 left1 = 0, right1 = length1, left2 = 0, right2 = length2, median1 = 0, median2 = 0, i,j;
            while(left1 <= right1)
            {
                i = (left1 + right1) / 2;
                j = (left2 + right2) / 2;

                if (i < 0) i = 0;
                if (j < 0) j = 0;
                if (j > length2) j = length2;
                if (i == length1 && j == length2) break;

                Int32 num1_i_1 = i == 0 ? Int32.MinValue : nums1[i - 1];
                Int32 num1_i = i == length1 ? Int32.MaxValue : nums1[i];
                Int32 num2_j_1 = j == 0 ? Int32.MinValue : nums2[j - 1];
                Int32 num2_j = j == length2 ? Int32.MaxValue : nums2[j];

                if (num1_i_1 > num2_j)
                {
                    right1 = i - 1;
                }
                else
                {
                    left1 = i + 1;
                }
                if (num2_j_1 > num1_i)
                {
                    right2 = i - 1;
                }
                else
                {
                    left2 = i + 1;
                }

                if (num1_i_1 <= num2_j && num2_j_1 <= num1_i)
                {
                    median1 = num1_i_1 >= num2_j_1 ? num1_i_1 : num2_j_1;       //取其最大
                    median2 = num1_i <= num2_j ? num1_i : num2_j;     //取其最小
                }
            }
            result = (length1 + length2) % 2 == 0 ? (median1 + median2) / 2.0D : median1;
            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public double DoAction2(int[] nums1, int[] nums2)
        {
            double result;
            Int32 length1 = nums1?.Length ?? 0, length2 = nums2?.Length ?? 0;
            //1. 场景1：nums1和nums2二者长度都为0
            if (0 == length1 && 0 == length2)
            {
                result = Scenes1();
            }
            //2. 场景2：nums1和nums2二者其中之一长度都为0
            else if (0 == length1 || 0 == length2)
            {
                result = Scenes2(length1 >= length2 ? nums1 : nums2);
            }
            //3. 场景3：nums1和nums2二者长度都大于0
            else
            {
                result = Scenes3(nums1, nums2);
            }
            return result;
        }

        #endregion

    }
}
