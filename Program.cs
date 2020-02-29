using System;

namespace Methods
{
    class Program
    {
        public static void PerformArithmeticOperation(int Num1, int Num2, int operation)
        {
            int result;
            switch (operation)
            {
                     //Addition
                case 1:
                    result = Num1 + Num2;
                    Console.WriteLine("The result of Addition for {0} and {1} is : {2}", Num1, Num2, result);
                    break;
                    //Subtraction
                case 2:
                    result = Num1 - Num2;
                    Console.WriteLine("The result of Subtraction for {0} and {1} is : {2}", Num1, Num2, result);
                    break;
                    //Multiplication
                case 3:
                    result = Num1 * Num2;
                    Console.WriteLine("The result of Multiplication for {0} and {1} is : {2}", Num1, Num2, result);
                    break;
                    //Division
                case 4:
                    if (Num2 == 0)
                    {
                        Console.WriteLine("Cannot perform divide operation as Num2 is {0}", Num2);
                        return;
                    }
                    //When dividing by 0
                    result = Num1 / Num2;
                    Console.WriteLine("The result of Division for {0} and {1} is : {2}", Num1, Num2, result);
                    break;
                    //Invalid operation
                default:
                    Console.WriteLine("Invalid flag for Arithmetic Operation");
                    break;
            }

            return;
        }

        static void Main(string[] args)
        {
            int Num1, Num2, operation;
            //My name at the top
            Console.Write("My name is: Jonathan Weaver" + Environment.NewLine);
            //First number to input
            Console.Write("Enter the First Number : ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            //Second line to input
            Console.Write("Enter the Second Number : ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            //Options to select the operation
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter the Operation you want to perform : ");
            operation = Convert.ToInt32(Console.ReadLine());
            PerformArithmeticOperation(Num1, Num2, operation);

            System.Environment.Exit(0);
        }

    }
}
