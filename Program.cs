using System;

namespace Calccy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("Calculator :>");
            Console.WriteLine("-------------");

            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;


                

                Console.WriteLine("Enter Number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter a Option:");
                Console.WriteLine("-----------------");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.WriteLine("-----------------");
                Console.WriteLine("\n");
                Console.WriteLine("Enter an option pls! \n");
                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result is: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result is: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result is: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result is: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.WriteLine("Would you like to re-use the calculator? (Y/N): ");
            } while (Console.ReadLine().ToUpper() == "Y");


            Console.WriteLine("Bye Bye!");
            Console.ReadKey();
        }
    }
}
