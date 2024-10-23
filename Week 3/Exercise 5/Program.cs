namespace Exercise_5
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
            PerformCalculation();
        }

        int Add(int a, int b)
        {
            return a + b;
        }

        int Subtract(int a, int b)
        {
            return a - b;
        }

        int Multiply(int a, int b)
        {
            return a * b;
        }

        double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Invalid number, cannot divide by 0.");
                return double.NaN; // Return NaN=Not-a-Number to indicate an invalid result.
            }
            return (double)a / b;
        }

        void DisplayMenu()
        {
            Console.WriteLine("Simple Calculator Menu:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
        }

        void PerformCalculation()
        {
            int choice;
            do
            {
                Console.WriteLine("");
                DisplayMenu();
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 5)
                {
                    Console.WriteLine("Exiting Console.");
                    break;
                }

                Console.Write("Enter the first number: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int number2 = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"result: {Add(number1, number2)}");
                        break;

                    case 2:
                        Console.WriteLine($"result: {Subtract(number1, number2)}");
                        break;

                    case 3:
                        Console.WriteLine($"result: {Multiply(number1, number2)}");
                        break;

                    case 4:
                        if (number2 == 0)
                        {
                            Console.WriteLine("Invalid number, cannot divide by 0.");
                        }
                        else
                        {
                            Console.WriteLine($"result: {Divide(number1, number2)}");
                        }
                        break;

                        default: 
                        Console.WriteLine("Invalid option: Please enter a valid a option (1-5)");
                        break;
                }
            } while (choice != 5);
        }
    }
}


// Difference between a DO WHILE LOOP = The do while loop will guarantee that the code will run at least 1 time. Because the condition will be checked after the loop has already gone through the code.
