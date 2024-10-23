namespace Exercise_7
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
            bool[] seats = new bool[10];

            InitializeSeats(seats);

            // Display the seats
            Console.WriteLine("Initial seating arrangement:");
            DisplaySeatingArrangement(seats);

            // Prompt the user to book a seat
            BookSeat(seats, 0);

            // Display the seats after booking
            Console.WriteLine("\nUpdated seating arrangement:");
            DisplaySeatingArrangement(seats);
        }

        void InitializeSeats(bool[] seats)
        {
            Random rnd = new Random();
            for (int i = 0; i < seats.Length; i++)
            {
                seats[i] = rnd.Next(0, 2) == 1;
            }
        }

        void DisplaySeatingArrangement(bool[] seats)
        {
            for (int i = 0; i < seats.Length; i++)
            {
                if (seats[i] == true)
                {
                    Console.WriteLine($"Seat {i + 1}: Available");
                }

                else
                {
                    Console.WriteLine($"Seat {i + 1}: Booked");
                }
            }
        }

        void BookSeat(bool[] seats, int seatNumber)
        {
            Console.Write("\nEnter the seat number to book (1-10): ");
            int input = int.Parse(Console.ReadLine());

            if (input > 0 && input <= 10)
            {
                if (seats[input - 1])
                {
                    seats[input - 1] = false;  // Book the seat (set it to false)
                    Console.WriteLine($"Seat {input} has been successfully booked.");
                }
                else
                {
                    Console.WriteLine($"Seat {input} is already booked.");  // Tell the user the seat is already taken
                }
            }
            else
            {
                Console.WriteLine("Invalid seat number. Please enter a number between 1 and 10.");  // If seat number is not valid, show an error
            }
        }
    }
}
