using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafios
{
    internal class Desafio_3
    {
        public static readonly int[] NUMBER_VALUES = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        public static readonly String[] NUMBER_LETTERS = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        static void Main(String[] args)    
        {
            String romanValue = Console.ReadLine();
            int result = FromRoman(romanValue);
            Console.WriteLine(result);
        }
        
        public static int FromRoman(String roman)
            {
                for (int i = 0; i < NUMBER_VALUES.Length; i++)
                {
                    if (roman.StartsWith(NUMBER_LETTERS[i]))
                    {
                        
                        return NUMBER_VALUES[i] + FromRoman(Regex.Replace(roman, "^" + NUMBER_LETTERS[i], ""));
                    }
                }
                return 0;
            }

    }
}

