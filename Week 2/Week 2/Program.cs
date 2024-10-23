﻿namespace Week_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18) 
            {
                Console.WriteLine($"You are a minor");
            }
            else
            {
                Console.Write("You are an adult");
            }
        }
    }
}
