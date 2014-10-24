﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._89
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string s = Console.ReadLine();

                try
                {
                    int i = int.Parse(s);
                    break;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You need to enter a value");
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not a valid number, Please try again, s");
                }
                finally
                {
                    Console.WriteLine("Program Complete");
                    Console.Read();
                }
            }
        }
    }
}
