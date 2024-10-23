﻿namespace Exercise_1
{
    internal class Program
    {
        const int NumberOfElements = 20;
        const int MinValue = 1;
        const int MaxValue = 100;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            int[] numbers = new int[NumberOfElements];
            FillArray(numbers);
            DisplayArray(numbers);
        }

        void FillArray(int[] numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++) 
            {
                numbers[i] = random.Next(MinValue, MaxValue +1);
            }
        }

        void DisplayArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element {i + 1} is: {numbers[i]}");
            }
        }
    }
}
