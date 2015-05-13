﻿using System;
using System.Linq;

class ReverseNumber
    {
        static void Main()
        {
            double inputNum = double.Parse(Console.ReadLine());
            double reversed = GetReversedNumber(inputNum);
            Console.WriteLine(reversed);
        }
        private static double GetReversedNumber(double inputNum)
        {
            bool isNegative = inputNum < 0;
            string input = string.Join("", inputNum.ToString().TrimStart('-').Reverse());
            double number = double.Parse(input);
            return isNegative ? -number : number;
        }
    }