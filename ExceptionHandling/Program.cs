using System;

namespace ExceptionHandling;

    class Program
    {
        public static void Main(string[]args)
        {
            try
            {
            int number1,number2;
            Console.WriteLine("Enter number1=");
            while(!int.TryParse(Console.ReadLine(),out number1))
            {
                Console.WriteLine("Invalid format");
            }
            Console.WriteLine("Enter number2=");
            while(!int.TryParse(Console.ReadLine(),out number2))
            {
                Console.WriteLine("Invalid format");
            }

            int result =number1/number2;
            Console.WriteLine(result);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Infinity");
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("System out of code.............");


        }
    }
