﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string[] students = new string[3] { "Bensu", "Selin", "Duygu" };
            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //

            if (IsPrimeNumber(4))
            {
                Console.WriteLine("This is a prime number");

            }
            else
            {

                Console.WriteLine("This is not a prime number");
            }

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
                
            }
            return result;
        }
            

    
    }
}
