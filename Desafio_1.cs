using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    internal class Desafio_1
    {
        static void Main(String[] args)
        {
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine(number + "!" + " = " + result);
        }
    }
}
