﻿/*
Import namespace called system that has many classes
and useful functions (Without it we'd have to type
System.Console.Write)
*/
using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("What is your name?" );
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
    }
}