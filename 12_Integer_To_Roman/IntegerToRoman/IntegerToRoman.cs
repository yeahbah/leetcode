using System;
using System.Collections.Generic;
using System.Text;

namespace IntegerToRoman
{
    public class Solution
    {
        public string IntToRoman(int num)
        {
            if (num < 0 || num > 3999) return "";

            var symbols = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" },
            };

            var result = "";
            while (num > 0)
            {                
                foreach (var symbol in symbols)
                {
                    int temp = num / symbol.Key;
                    if (temp > 0)
                    {
                        num -= symbol.Key;
                        result += symbol.Value;
                        break;
                    }                    
                }
            }

            return result;
        }

        // https://leetcode.com/problems/integer-to-roman/discuss/1493756/Java-100-Faster
        public string IntToRoman2(int num)
        {
            var symbol = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            var value = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            var sb = new StringBuilder();
            for (int i = 0; i < symbol.Length; i++)
            {
                while (num >= value[i])
                {
                    sb.Append(symbol[i]);
                    num -= value[i];
                }
            }
            return sb.ToString();
        }
    }
}
