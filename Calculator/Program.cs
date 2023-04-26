namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                try
                {
                    Console.Write("Enter your first number: ");
                    num1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter your second number: ");
                    num2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter an option");
                    Console.WriteLine("\t+ : Add");
                    Console.WriteLine("\t- : Subtract");
                    Console.WriteLine("\t* : Multiply");
                    Console.WriteLine("\t/ : Divide");
                    Console.Write("Enter an option: ");

                    switch (Console.ReadLine())
                    {
                        case "+":
                            result = num1 + num2;
                            Console.WriteLine($"Your result: {num1} + {num2} = {result}");
                            break;

                        case "-":
                            result = num1 - num2;
                            Console.WriteLine($"Your result: {num1} - {num2} = {result}");
                            break;

                        case "*":
                            result = num1 * num2;
                            Console.WriteLine($"Your result: {num1} * {num2} = {result}");
                            break;

                        case "/":
                            result = num1 / num2;
                            Console.WriteLine($"Your result: {num1} / {num2} = {result}");
                            break;

                        default:
                            Console.WriteLine("Unvalid option");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number");
                }

                Console.Write("Would you like to continue? (Y = yes, N = no): ");

            } while (Console.ReadLine().ToUpper() == "Y");


        }
    }
}