using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatterns_ForLoop
{
    internal class Patterns

        {
            public int num { get; set; }

            private void GetNumberFromUser()
            {
                Console.WriteLine("Enter Any Number:");
                num = Convert.ToInt32(Console.ReadLine());
            }
            public void pattern1()
            {
                GetNumberFromUser();

                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            public void pattern2()
            {
                GetNumberFromUser();

                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            public void pattern3()
            {
                GetNumberFromUser();

                for (int i = num; i >= 1; i--)
                {
                    for (int j = 1; j <= 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            public void pattern4()
            {
                GetNumberFromUser();

                for (int i = num; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    {
                        Console.WriteLine();
                    }
                }
            }
            public void pattern5()
            {
                GetNumberFromUser();

                for (int i = 1; i <= num; i++)
                {
                    for (int k = num - i; k >= 1; k--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    {
                        Console.WriteLine();
                    }
                }
            }
            public void pattern6()
            {
                GetNumberFromUser();

                for (int i = 1; i <= num; i++)
                {
                    Console.Write("  ");
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    {
                        Console.WriteLine();
                    }
                }
                for (int i = num - 1; i >= 1; i--)
                {
                    Console.Write("  ");
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    {
                        Console.WriteLine();
                    }
                }
            }
            public void pattern7()
            {
                GetNumberFromUser();
                for (int i = 1; i <= num; i++)
                {
                    Console.Write("  ");
                    for (int k = num - i; k >= 1; k--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    {
                        Console.WriteLine();
                    }
                }
                for (int i = num - 1; i >= 1; i--)
                {
                    Console.Write("  ");
                    for (int k = num - i; k >= 1; k--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    {
                        Console.WriteLine();
                    }
                }
            }
            public void pattern8()
            {

                GetNumberFromUser();

                for (int i = 1; i <= num; i++)
                {
                    for (int k = 1; k <= num - i; k++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }



                    for (int j = 1; j <= i - 1; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }

                for (int i = num - 1; i >= 1; i--)
                {
                    for (int k = 1; k <= num - i; k++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }

                    for (int j = 1; j <= i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }


