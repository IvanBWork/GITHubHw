namespace GITHubHw
{
    internal class Program
    {
        static void AutoCalc(int num1, int num2, string operation)
        {
            int result = 0;

            if (operation == "+")
            {
                result = num1 + num2;
            }
            if (operation == "-")
            {
                result = num1 - num2;
            }
            if (operation == "/")
            {
                result = num1 / num2;
            }
            if (operation == "*")
            {
                result = num1 * num2;
            }

            Console.WriteLine($"The result of the operation = {result}");
        }

        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                int number1 = int.Parse(args[0]);

                string operation = args[1];

                int number2 = int.Parse(args[2]);

                AutoCalc(number1, number2, operation);

            }
            else
            {
                Console.Write("Enter the first number: ");

                int number1 = int.Parse(Console.ReadLine()!);

                Console.Write("Enter the desired operation (+, -, /, *): ");

                string operation = Console.ReadLine()!;

                Console.Write("Enter the second number: ");

                int number2 = int.Parse(Console.ReadLine()!);

                AutoCalc(number1, number2, operation);
            }
        }
    }
}
