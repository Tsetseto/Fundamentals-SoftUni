﻿using System;

namespace MoreExercise04._Refactoring__Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());
            for (int i = 2; i<=n; i++)
{
                string isPrime = "true";
                for (int j = 2; j<i; j++)
{
                    if (i % j == 0)
                    {
                        isPrime = "false";
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, isPrime);
            }
        }
    }
}
