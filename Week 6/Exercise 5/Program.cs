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
            int originalValue = 10;

            // Display original value
            Console.WriteLine($"Original value: {originalValue}");

            // Call ModifyByValue method
            ModifyByValue(originalValue);
            Console.WriteLine($"Value after ModifyByValue: {originalValue}"); // Should remain 10

            // Call ModifyByReference method
            ModifyByReference(ref originalValue);
            Console.WriteLine($"Value after ModifyByReference: {originalValue}"); // Should be 20

        }
        void ModifyByValue(int value)
        {
            value += 10;
        }

        void ModifyByReference(ref int value)
        {
            value += 10;
        }
    }

}


