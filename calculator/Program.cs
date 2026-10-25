namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calculator
            Console.Write("FIRST NUMBER: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("OPERATION (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("SECOND NUMBER: ");
            double b = double.Parse(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine($"RESULT: {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"RESULT: {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"RESULT: {a * b}");
                    break;
                case "/":
                    if (b == 0)
                        Console.WriteLine("can not divide by zero");
                    else
                        Console.WriteLine($"RESULT: {a / b}");
                    break;
                default:
                    Console.WriteLine("INVALID OPERATION");
                    break;
            }
        }
    }
}
