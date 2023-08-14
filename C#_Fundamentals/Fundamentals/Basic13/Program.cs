using System;
using System.Globalization;

namespace Basic13 // Note: actual namespace depends on the project name.
{
    class Program
    {
        //Print 1-255
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }

        }
        //Print odd numbers between 1-255
        public static void PrintOdds()
        {
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        //Print Sum
        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine("New number: " + i + " Sum " + sum);
            }
        }
        //Iterating through an Array
        public static void LoopArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        //Find Max
        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;

        }
        //Get Average
        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum / numbers.Length);
        }
        //Array with Odd Numbers
        public static int[] OddArray()
        {
            int[] y = new int[255];
            int counter = 0;
            for (int i = 1; i < 255; i++)
            {
                if (i % 2 == 0)
                {
                    y[counter] = i;
                    counter++;
                }
            }
            return y;
        }
        //Greater than Y
        public static int GreaterThanY(int[] numbers, int y)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (y > numbers[i])
                {
                    sum += 1;
                }
            }return sum ;
        }
  


    static void Main(string[] args)
    {
        // PrintNumbers();
        // PrintOdds();
        // PrintSum();
        int[] x = { 1, 3, 4, 5, 6 };
        // LoopArray(x);
        // Console.WriteLine(FindMax(x));
        // GetAverage(x);
        // Console.WriteLine(OddArray);
        // Console.WriteLine(GreaterThanY);
    }
}
}
