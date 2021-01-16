using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = {-22,-15, 1, 4, 5, 8, 22, 99, 105 };


            Console.WriteLine(RecursiveBinarySearch(intArray, 1));
            Console.WriteLine(RecursiveBinarySearch(intArray, 33));
            Console.WriteLine(RecursiveBinarySearch(intArray, 99));
            Console.WriteLine(RecursiveBinarySearch(intArray, 6));

            Console.ReadLine();
        }

        public static int IterativeBinarySearch(int[] input, int value)
        {
            int start = 0;
            int end = input.Length;

            while (start < end)
            {
                int midpoint = (end + start) / 2;
                Console.WriteLine($"Midpoint = {midpoint}");
                if (input[midpoint] == value)
                {
                    return midpoint;
                }
                else if (input[midpoint] < value)
                {
                    start = midpoint + 1;
                }
                else
                {
                    end = midpoint;
                }
            }
            return -1;
        }

        public static int RecursiveBinarySearch(int[] input, int value)
        {

            // Teacher
            return RecursiveBinarySearch(input, 0, input.Length, value);
        }

        public static int RecursiveBinarySearch(int[] input, int start, int end, int value)
        {
            if (start >= end)
            {
                return -1;
            }
            int midpoint = (start + end) / 2;
            Console.WriteLine($"Midpoint = {midpoint}");

            if (input[midpoint] == value)
            {
                return midpoint;
            }
            else if (input[midpoint] < value)
            {
                return RecursiveBinarySearch(input, midpoint + 1, end, value);
            }
            else
            {
                return RecursiveBinarySearch(input, start, midpoint, value);
            }
        }
    }
}
