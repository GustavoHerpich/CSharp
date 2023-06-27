using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

namespace Desafios
{
    internal class Desafio_2
    {
        static void Main(String[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    
                }
                if (i%3 == 0)
                {
                    Console.WriteLine("Fizz");
                    
                } 
                if (i%5 == 0)
                {
                    Console.WriteLine("Buzz");
                    
                } 
                else
                {
                    Console.WriteLine(i);
                    
                }
            }

        }
    }
}