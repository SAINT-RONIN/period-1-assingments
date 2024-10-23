namespace Exercise_8
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
            Console.Write("How many books should there be in the library: ");
            int userInput = int.Parse(Console.ReadLine());

            Book[] books = new Book[userInput];
            for (int i = 0; i < userInput; i++) 
            {
                Console.WriteLine("Enter book title: ");
                string title = Console.ReadLine();

                Console.Write("Enter book author: ");
                string author = Console.ReadLine();

                books[i] = new Book(title, author);
            }

            DisplayBooks(books);
        }

        void DisplayBooks(Book[] books)
        {
            Console.WriteLine("\nBooks in library:");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{books[i].Title} by {books[i].Author}");
            }
        }
    }
}
