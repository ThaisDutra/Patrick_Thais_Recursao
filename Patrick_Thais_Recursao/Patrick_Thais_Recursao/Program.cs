using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick_Thais_Recursao
{
    class Program
    {
        static long Fatorial(int n)
        {
            
            if (n <= 0)
                return 1;
            else return n * Fatorial(n - 1);
        }

    
        static void Main(string[] args)
        {
            for (int i = 0; i <= 6; i++)
            {
                
                Console.WriteLine("{0} ! = {1}", i, Fatorial(i));
            }
            
            Console.ReadLine();
        }
      }
}