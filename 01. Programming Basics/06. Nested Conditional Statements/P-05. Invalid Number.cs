﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_05.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (number >= 100 && number <= 200 || number == 0)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
