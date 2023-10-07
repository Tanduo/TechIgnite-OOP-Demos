using TestApplication;

class Program
{
    private static Calculator _calc = new Calculator();
    static void Main(string[] args)
    {
        _calc.powerOn();
        while (true)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Multiply");
            Console.WriteLine("3. Square");
            Console.WriteLine("4. Square Root");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the first number: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(_calc.Add(num1, num2));
                    break;
                case "2":
                    Console.Write("Enter the first number: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(_calc.Multiply(num1, num2));
                    break;

                case "3":
                    Console.Write("Enter a number: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(_calc.Square(num1));
                    break;

                case "4":
                    Console.Write("Enter a number: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(_calc.SquareRoot(num1));
                    break;

                case "5":
                    _calc.powerDown();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
