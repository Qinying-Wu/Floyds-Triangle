using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floyd_s_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows to display: ");
            string input = Console.ReadLine();
            int num, increment = 1;
            int.TryParse(input, out num);
            int[] arr = new int[] { };
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(Convert.ToString(increment));
                    if (j != num - 1)
                    {
                        Console.Write(" ");
                    }
                    increment++;
                }
                Console.WriteLine();
            }

        }
    }
}

