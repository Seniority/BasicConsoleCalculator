using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleCalculator
{
    class Program
    {
        public static bool keepGoing = true;
        public static double num1;
        public static double num2;

        static void Main(string[] args)
        {
            Console.WriteLine("== Welcome to Console Calculator ==");
            Console.WriteLine();

            while (keepGoing)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("0. Exit");
                Console.Write("Action: ");
                MenuSelection(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine();
            }
        }// end Main

        public static void MenuSelection(int selection)
        {
            switch (selection)
            {
                case 0:
                    keepGoing = false;
                    break;
                case 1:
                    Console.WriteLine("Enter two numbers you would like to add: ");
                    num1 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("+");
                    num2 = Double.Parse(Console.ReadLine());
                    double sum = Add(num1, num2);
                    Console.WriteLine(num1 + " + " + num2 + " = " + sum);
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Enter the numbers you would like to subtract: ");
                    num1 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("-");
                    num2 = Double.Parse(Console.ReadLine());
                    double difference = Subtract(num1, num2);
                    Console.WriteLine(num1 + " - " + num2 + " = " + difference);
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Enter the numbers you would like to multiply: ");
                    num1 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("*");
                    num2 = Double.Parse(Console.ReadLine());
                    double product = Multiply(num1, num2);
                    Console.WriteLine(num1 + " * " + num2 + " = " + product);
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Enter the numbers you would like to divide: ");
                    num1 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("/");
                    num2 = Double.Parse(Console.ReadLine());
                    double quotient = Divide(num1, num2);
                    Console.WriteLine(num1 + " + " + num2 + " = " + quotient);
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Not a valid selection");
                    break;
            }
        }

        public static double Add(double _num1, double _num2)
        {
            double sum = _num1 + _num2;
            return sum;
        }

        public static double Subtract(double _num1, double _num2)
        {
            double difference = _num1 - _num2;
            return difference;
        }

        public static double Multiply(double _num1, double _num2)
        {
            double product = _num1 * _num2;
            return product;
        }

        public static double Divide(double _num1, double _num2)
        {
            double quotient = _num1 / _num2;
            return quotient;
        }

    }// end Class
}// end Namespace
