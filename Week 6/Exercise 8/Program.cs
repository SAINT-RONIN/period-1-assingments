namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start () 
        {
            BankAccount bankAccount = new BankAccount("123456", 0.00);

            Console.Write("Enter a deposit amount: ");
            double depositAmount = double.Parse(Console.ReadLine());
            bankAccount.Deposit(depositAmount);

            Console.WriteLine("\nEnter withdrawal amount: ");
            double withdrawal = double.Parse(Console.ReadLine());
            bankAccount.Withdraw(withdrawal);

            Console.WriteLine("\nAccount Details:");
            Console.WriteLine($"Account Number: {bankAccount.AccountNumber}");
            Console.WriteLine($"Balance: {bankAccount.Balance:0.00}");


        }
    }
}
