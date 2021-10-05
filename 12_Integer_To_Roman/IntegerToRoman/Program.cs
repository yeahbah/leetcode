using System;
using System.Collections.Generic;

namespace IntegerToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            //Console.WriteLine(IntegerToRoman.ConvertIntToRoman(3000));
            //Console.WriteLine(IntegerToRoman.ConvertIntToRoman(1));
            //Console.WriteLine(IntegerToRoman.ConvertIntToRoman(2));
            //Console.WriteLine(IntegerToRoman.ConvertIntToRoman(10));
            //Console.WriteLine(IntegerToRoman.ConvertIntToRoman(50));
            //Console.WriteLine(IntegerToRoman.ConvertIntToRoman(100));
            //Console.WriteLine(IntegerToRoman.ConvertIntToRoman(500));
            Console.WriteLine(solution.IntToRoman(4));
            Console.WriteLine(solution.IntToRoman(40));
            Console.WriteLine(solution.IntToRoman(400));
            Console.WriteLine(solution.IntToRoman(9));
            Console.WriteLine(solution.IntToRoman(90));
            Console.WriteLine(solution.IntToRoman(900));
            Console.WriteLine(solution.IntToRoman(1994));
        }
    }
}
