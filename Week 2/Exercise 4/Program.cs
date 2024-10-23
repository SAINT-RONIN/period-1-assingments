namespace Exercise_4
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
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            int result = CalculateResult(number1, number2, operation);
            Console.WriteLine("The result is: " + result);
        }

        int CalculateResult(int number1, int number2, string operation)
        {
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;

                case "-":
                    result = number1 - number2;
                    break;

                case "*":
                    result = number1 * number2;
                    break;

                case "/":
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

            return result;
        }
    }
}
