using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StarPatterns_ForLoop
{
    internal class LogicalPrograms
    {
        public void OddNumbers()
        {
            Console.WriteLine("Please enter the limit for odd numbers");
            int Limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Odd Numbers Are:");

            for (int i = 1; i <= Limit; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
                
            }
        }

        public void Tables()
        {
            Console.WriteLine("Please Enter the limit for Tables");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Displaying Tables:");

            for(int i = 1; i <= limit; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.Write("|" + j * i);
                }
                Console.WriteLine();
            }

        }
    }
}
