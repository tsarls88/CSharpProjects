using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double n1 = 0;
                double n2 = 0;
                double results = 0;

                Console.Write("Enter Desire First Number:  ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Desire Second Number ");
                n2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Option");
                Console.WriteLine("\t +: ADD");
                Console.WriteLine("\t -: MINUS");
                Console.WriteLine("\t /: DIVIDE");
                Console.WriteLine("\t *: MULTIPLY");

                switch (Console.ReadLine())
                {
                    case "+":
                        results = n1 + n2;
                        Console.WriteLine($"Your Results is: {n1} + {n2} =" + results);
                        break;
                    case "-":
                        results = n1 - n2;
                        Console.WriteLine($"Your Result is: {n1} - {n2} = " + results);
                        break;
                    case "/":
                        results = n1 / n2;
                        Console.WriteLine($"Your Result is: {n1} - {n2} = " + results);
                        break;
                    case "*":
                        results = n1 * n2;
                        Console.WriteLine($"Your result is: {n1} * {n2} = " + results);
                        break;
                    default:
                        Console.WriteLine("INVALID INPUT!");
                        break;
                }
                Console.Write("Would you like to continue? (Y = yes, N = No):");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Bye!");
            Console.ReadKey();





        }
    }
}
