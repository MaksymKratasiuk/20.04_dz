using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._04_dz
{
    public delegate bool FilterDelegate(int number);

    public static class ArrayExtensions
    {
        public static int[] GetEvenNumbers(this int[] array)
        {
            return FilterArray(array, IsEven);
        }

        public static int[] GetOddNumbers(this int[] array)
        {
            return FilterArray(array, IsOdd);
        }

        public static int[] GetPrimeNumbers(this int[] array)
        {
            return FilterArray(array, IsPrime);
        }

        public static int[] GetFibonacciNumbers(this int[] array)
        {
            return FilterArray(array, IsFibonacci);
        }

        private static int[] FilterArray(int[] array, FilterDelegate filter)
        {
            int[] result = new int[array.Length];
            int index = 0;

            foreach (int number in array)
            {
                if (filter(number))
                {
                    result[index] = number;
                    index++;
                }
            }

            Array.Resize(ref result, index);
            return result;
        }

        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        private static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsFibonacci(int number)
        {
            int a = 0;
            int b = 1;

            while (b < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return b == number;
        }
    }
    internal class Task1
    {
        public static void task1()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            Console.WriteLine("All even numbers:");
            int[] evenNumbers = numbers.GetEvenNumbers();
            PrintArray(evenNumbers);

            Console.WriteLine("\nAll odd numbers:");
            int[] oddNumbers = numbers.GetOddNumbers();
            PrintArray(oddNumbers);

            Console.WriteLine("\nAll prime numbers:");
            int[] primeNumbers = numbers.GetPrimeNumbers();
            PrintArray(primeNumbers);

            Console.WriteLine("\nAll Fibonacci numbers:");
            int[] fibonacciNumbers = numbers.GetFibonacciNumbers();
            PrintArray(fibonacciNumbers);
        }
        static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
    
}
