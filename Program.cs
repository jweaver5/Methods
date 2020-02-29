using System;

namespace Methods
{
    class Program
    {
        public static int PerformArithmeticOperation(int Num1, int Num2, char operation)
        {
            int result;
            switch (operation)
            {
                    //Addition
                case '+':
                    result = Num1 + Num2;
                    Console.WriteLine("The result of Addition for {0} and {1} is : {2}", Num1, Num2, result);
                    break;
                    //Subtraction
                case '-':
                    result = Num1 - Num2;
                    Console.WriteLine("The result of Subtraction for {0} and {1} is : {2}", Num1, Num2, result);
                    break;
                    //Multiplication
                case '*':
                    result = Num1 * Num2;
                    Console.WriteLine("The result of Multiplication for {0} and {1} is : {2}", Num1, Num2, result);
                    break;
                    //Division
                case '/':
                    if (Num2 == 0)
                    {
                        Console.WriteLine("Cannot perform divide operation as Num2 is {0}", Num2);
                        return 0;
                    }
                    result = Num1 / Num2;
                    Console.WriteLine("The result of Division for {0} and {1} is : {2}", Num1, Num2, result);
                    break;
                default:
                    Console.WriteLine("Invalid flag for Arithmetic Operation");
                    return 0;
            }
            return 1;
        }
        static void Main(string[] args)
        {
            //Display my name
            Console.WriteLine("My Name is: Jonathan Weaver");
            int Num1, Num2;
            //Display user input for first numbers
            Console.Write("Enter the First Number : ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            int success = PerformArithmeticOperation(Num1, Num2, '+');
            if (success == 0)
            {
                System.Environment.Exit(0);
            }
            success = PerformArithmeticOperation(Num1, Num2, '-');
            if (success == 0)
            {
                System.Environment.Exit(0);
            }
            success = PerformArithmeticOperation(Num1, Num2, '*');
            if (success == 0)
            {
                System.Environment.Exit(0);
            }
            success = PerformArithmeticOperation(Num1, Num2, '/');

            System.Environment.Exit(0);
        }
    }
}
