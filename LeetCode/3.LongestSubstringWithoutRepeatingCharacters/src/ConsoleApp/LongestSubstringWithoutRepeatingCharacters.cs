using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    /**
     * 地址：
     *     https://leetcode-cn.com/problems/longest-substring-without-repeating-characters/?utm_source=LCUS&utm_medium=ip_redirect&utm_campaign=transfer2china
     * 
     * 犯错：
     *     没有进行手写尝试，一直在电脑上进行编码测试
     *     
     * 前提：
     *     由于看书时，看过类似的问题的解决方案，所以解题时有一些思路
     * 
     * 解决方案思路：
     *     在进行遍历时，“记忆”之前已经遍历过的字符，当遇到重复字符时，起始位置+1（如之前再次遇到重复字符，如索引小于起始索引，则不进行计算）
     * 
     */

    /// <summary>
    /// 
    /// </summary>
    public class LongestSubstringWithoutRepeatingCharacters
    {

        //public int DoAction(string s)
        //{
        //    Int32 maxWithoutRepeatingCharactersSubstringLength = 0, cuerrentWithoutRepeatingCharactersSubstringLength;
        //    List<Char> withoutRepeatingCharactersSubstring = new List<Char>();
        //    if (!String.IsNullOrEmpty(s))
        //    {
        //        Int32 i = 0, stringLength = s.Length;
        //        for (; i < stringLength; i++)
        //        {
        //            if (withoutRepeatingCharactersSubstring.Contains(s[i]))
        //            {
        //                if (withoutRepeatingCharactersSubstring.Count > maxWithoutRepeatingCharactersSubstringLength)
        //                {
        //                    maxWithoutRepeatingCharactersSubstringLength = withoutRepeatingCharactersSubstring.Count;
        //                }
        //                withoutRepeatingCharactersSubstring.Clear();
        //            }
        //            withoutRepeatingCharactersSubstring.Add(s[i]);
        //        }

        //        if (withoutRepeatingCharactersSubstring.Count > maxWithoutRepeatingCharactersSubstringLength)
        //        {
        //            maxWithoutRepeatingCharactersSubstringLength = withoutRepeatingCharactersSubstring.Count;
        //        }
        //    }

        //    return maxWithoutRepeatingCharactersSubstringLength;
        //}

        public int DoAction(string s)
        {
            Int32 maxWithoutRepeatingCharactersSubstringLength = 0, cuerrentWithoutRepeatingCharactersSubstringLength = 0;
            if (!String.IsNullOrEmpty(s))
            {
                Dictionary<char, Int32> m_dict = new Dictionary<char, int>();
                Int32 i = 0, startIndex = 0, stringLength = s.Length;
                for (; i < stringLength; i++)
                {
                    if (m_dict.ContainsKey(s[i]))
                    {
                        //如重复字符的索引大于起始索引，则起始索引+1
                        if(m_dict[s[i]] + 1 > startIndex)
                            startIndex = m_dict[s[i]] + 1;
                        //移除“记忆中”已存在和当前字符重复的字符
                        m_dict.Remove(s[i]);
                    }
                    //“记忆”已经遍历过的字符
                    m_dict.Add(s[i], i);
                    //记录子串的长度
                    cuerrentWithoutRepeatingCharactersSubstringLength = i - startIndex + 1;
                    //判断子串是否大于已记录的最长子串，如大于，则替换
                    if (cuerrentWithoutRepeatingCharactersSubstringLength >
                        maxWithoutRepeatingCharactersSubstringLength)
                        maxWithoutRepeatingCharactersSubstringLength =
                            cuerrentWithoutRepeatingCharactersSubstringLength;
                    //maxWithoutRepeatingCharactersSubstringLength = Math.Max(maxWithoutRepeatingCharactersSubstringLength, cuerrentWithoutRepeatingCharactersSubstringLength);
                }
            }
            return maxWithoutRepeatingCharactersSubstringLength;
        }

    }
}
