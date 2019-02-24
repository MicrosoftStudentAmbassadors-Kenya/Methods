using System;
namespace Methods
{
    class Program
    {

        static void Main(string[] args)
        {
             /*
            When calling/Invoking methods , we sipmly write the name of the method in main method followed by rounded brackets
             and a semicolon 
            access modifiers like private , public etc determine the accessibility of the method
            A method must have method name , parameters , returntype and access modifiers 
            We supply the method with arguments when calling it  , which replace the parameters when creating the method
             */

            //print outs to the console
            Console.WriteLine("Hello World!");
            // variable num , num3 declaration and initialization
            int num = 85;
            int num3 = 65;
           //static method calls
            GetName();
            AddNumbers();
            GetSum(45, 80);
            
           int finalvalue= GetSum(num3, num);
           Console.WriteLine(finalvalue);
           //simpler way is to do the print out directly
           //console.WriteLine(GetSum(num3,num))
        }

        static string GetName()
        {
            //prints out the request to the console
            Console.WriteLine("Enter your name");
            //accepts the request from the console
            string name = Console.ReadLine();
            return name;
        }

        static int AddNumbers( )
        {  
            // Try using TryParse => handles exceptions
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

        //Try writing a method that sums alot of numbers => you can call the method as follows
        // GetSum(1,2,3,4,5,6,6,7,8)
        // GetSum(1,2,3,4,5)
    }
}
