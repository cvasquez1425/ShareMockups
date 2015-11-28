﻿
using System;

namespace ShareMockups.Helper
{
    public class TestExtensions
    {
        static void Main(string[] args)
        {
            string zipCode = "33334";

            bool result = StringExtensions.IsValidPostalCode(zipCode);

            bool result2 = zipCode.IsValidPostalCode();

            string text = "43.35";
            double data = text.ToDouble();
        }

        // Func and Action Delegate types
        private static void ActionsAndFuncs()
        {
            //Action never return a value
            Action printEmptyLine   = () => Console.WriteLine();
            Action<int> printNumber = (x) => Console.WriteLine(x);
            Action<int, int> printTwoNumbers = (x, y) => Console.WriteLine(String.Format("{ 0 }\n{1}", x, y));   // \n newline
                                                                                                                 //Or   {
                                                                                                                 //       Console.WriteLine(x);
                                                                                                                 //       Console.WriteLine(y);
                                                                                                                 //   };
            // Write a Lambda Expression that will return a DateTime Generic type parameter
            Func<DateTime> getTime = () => DateTime.Now;
            Func<int, int> square = x => x * x;   // Multiple Generic type parameter it is always the last parm that return the value. 
                                                  // this funch takes an int and return an Int.
            Func<int, int, int> Multiply = (x, y) => x * y;   // It means a Lambda expression that takes 2 parm Int, Int and return an Int

            //Func always return at least one  value


            printEmptyLine();
            printNumber(3);
            printTwoNumbers(5, 10);

            DateTime now = getTime();
            int z        = Multiply(5, 15);
        }

    }
}