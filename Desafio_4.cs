using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    internal class Desafio_4
    {
        static void Main(String[] args)
        {
            string S = Console.ReadLine();
            string T = Console.ReadLine();

            for (int i = 0; i < S.Length; i++)
            {
                char Letra = S[i];
                
                if (T.IndexOf(Letra) == -1 ) {
                    Console.WriteLine("False");
                    return;
                }
                T = T.Remove(i,1);
                
            }
            Console.WriteLine("True");
        }
        
    }
}
