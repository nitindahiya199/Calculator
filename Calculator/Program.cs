using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int result;
                Console.WriteLine("Enter Your First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Second Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What Do You Want To Do With Them..?!");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("Addition of both number is " + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("Subtraaction of both number is " + result);
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("multiple of both number is " + result);
                        break;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("Divison of both number is " + result);
                        break;

                    default:
                        Console.WriteLine("Kindly Choose From + - * / and try again");
                        break;



                }
                Console.ReadLine();
                Console.WriteLine("Do You Want To Continue: 'y' or 'n'");
                value = Console.ReadLine();
            }
            while (value == "Y" || value == "y ");
        }
    }
}
