using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitCarpimTablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("-------------");
                for (int j = 1; j <= 10; j++)
                {
                    z = i * j;
                    Console.WriteLine(i + " X " + j + " = " + z);
                }
            }
            Console.ReadKey();
        }
    }
}
