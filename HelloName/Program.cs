﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            PrintName(input);
                   
        }

        public static void PrintName(String name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
