
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printCommand
{
    internal class Program 
    {
        static void Main(string[] args)
        {

            {

                {
                    Console.Write("Enter a number");
                    int num = int.Parse(Console.ReadLine());


                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                            Console.WriteLine("this number is not prime ");
                        return;     

                    }
                    Console.WriteLine("This number is prime");

                }
            }
        }
    }
}

