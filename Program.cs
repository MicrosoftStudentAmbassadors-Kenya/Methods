using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = 85;
            int num3 = 65;
            //When calling/Invoking methods , we sipmly write the name of the method in main method followed by rounded brackets
            // and a semicolon 
            //access modifiers like private , public etc determine the accessibility of the method
            //A method must have method name , parameters , returntype and access modifiers 
            //We supply the method with arguments when calling it  , which replace the parameters when creating the method
            GetName();
            AddNumbers();
            GetSum(45, 80);
           int finalvalue= GetSum(num3, num);
           Console.WriteLine(finalvalue);
        }

        static string GetName()
        {
            System.Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            return name;
        }

        static int AddNumbers( )
        {  
            int   number1 = int.Parse(Console.ReadLine());
            int   number2=Int32.Parse(Console.ReadLine());
            int  sum = number1 + number2;
            return sum;
        }

        static int GetSum(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
    }
}
