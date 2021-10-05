using System;
using System.Collections.Generic;

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
                    decimal temp = num / symbol.Key;
                    if (Math.Truncate(temp) > 0)
                    {
                        num -= symbol.Key;
                        result += symbol.Value;
                        break;
                    }                    
                }
            }

            return result;
        }
    }
}
