using System;
namespace Assignment_1
{
    internal class Calculator
    {
       public int calculate(int a , int b , string op)
        {
            switch (op) {
                case "+":
                return a + b;
                case "-":
                return a - b;
                case "*":
                return a * b;
                case "/":
                return a / b;
                default:  
                Console.WriteLine("The shit was wrong.");
                return 0;

            }
        }
    }
}

