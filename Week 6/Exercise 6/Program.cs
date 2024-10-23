namespace Exercise_6
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
            Console.Write("Enter account holder name: ");
            string accountHolder = Console.ReadLine();

            // Create an Account object
            Account account = new Account(accountHolder);

            // Prompt user for deposit amount
            Console.Write("Enter deposit amount: ");
            double depositAmount = double.Parse(Console.ReadLine());

            // Call Deposit method
            account.Deposit(depositAmount);

            // Display account information
            account.DisplayAccountInfo();
        }
    }
}
