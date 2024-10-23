namespace Exercise_7
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
            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();

            // Prompt user for product price
            Console.Write("Enter product price: ");
            double productPrice = double.Parse(Console.ReadLine());

            // Create a Product object
            Product product = new Product(productName, productPrice);

            // Display product details
            Console.WriteLine("\nProduct Details:");
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Price: {product.Price}");
        }
    }
}
