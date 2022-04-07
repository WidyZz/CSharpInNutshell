using System;
using System.Collections.Generic;

namespace CSharpInNutshell
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a + 1;


            //Console.WriteLine($"test = {test}");
            //Console.WriteLine("{0} + 1 = {1}", a, b);
            MinMaxValues();
            string helloWorldFromMethod = MethodThatReturnsString();
            int sumOfNumbersUsingMethod = MethodThatReturnsInt(10,5);
            int divideByZero = ExceptionInt(5,0);
            Console.WriteLine(helloWorldFromMethod + " " + sumOfNumbersUsingMethod + " " + divideByZero);

            Fibonacci();
        }
        static void MinMaxValues()
        {
            int intMax = int.MaxValue;
            int intMin = int.MinValue;
            sbyte sbyteMax = sbyte.MaxValue;
            sbyte sbyteMin = sbyte.MinValue;
            float floatMax = float.MaxValue;
            float floatMin = float.MinValue;
            decimal decMax = decimal.MaxValue;
            decimal decMin = decimal.MinValue;
            byte byteMax = byte.MaxValue;
            byte byteMin = byte.MinValue;
            bool boolMax = true;
            bool boolMin = false;
            long longMax = long.MaxValue;
            long longMin = long.MinValue;
            Console.Write($"Int32: \n{"Max",5} = {intMax} \n{"Min",5} = {intMin}\n" +
                          $"Sbyte: \n{"Max",5} = {sbyteMax} \n{"Min",5} = {sbyteMin}\n" +
                          $"Float: \n{"Max",5} = {floatMax} \n{"Min",5} = {floatMin}\n" +
                          $"Decimal: \n{"Max",5} = {decMax} \n{"Min",5} = {decMin}\n" +
                          $"Byte: \n{"Max",5} = {byteMax} \n{"Min",5} = {byteMin}\n" +
                          $"Bool: \n{"Max",5} = {boolMax} \n{"Min",5} = {boolMin}\n" +
                          $"Long: \n{"Max", 5} = {longMax} \n{"Min",5} = {longMin}\n\n");
        }
        static string MethodThatReturnsString()
        {
            return "Hello World!";
        }
        static int MethodThatReturnsInt(int a, int b)
        {
            return a + b;
        }
        static int ExceptionInt(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return -1;
        }
        static void Fibonacci()
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            while(fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            fibonacciNumbers.ForEach(x =>
            {
                Console.WriteLine(x);
            });
        }
    }
}
