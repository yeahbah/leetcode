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
            Console.WriteLine(solution.IntToRoman2(4));
            Console.WriteLine(solution.IntToRoman2(40));
            Console.WriteLine(solution.IntToRoman2(400));
            Console.WriteLine(solution.IntToRoman2(9));
            Console.WriteLine(solution.IntToRoman2(90));
            Console.WriteLine(solution.IntToRoman2(900));
            Console.WriteLine(solution.IntToRoman2(1994));
        }
    }
}
