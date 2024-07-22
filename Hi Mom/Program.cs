using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Mom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is a single line comment
            /*
             this is a multi-line comment
             */

            //Console.WriteLine("Hi Mom!");
            //Console.Write(69);
            //Console.WriteLine("Hi Usman!");

            //declaring variable
            //int num = 420;
            //Console.WriteLine("My number is " + num);

            /* Data type are:
             Integar - int num = 12; --> 4 bytes
             Long - long num = 12; --> 8 bytes
             Floating Point Number - float thisF; --> 4 bytes
             Double - double thatD; --> 8 bytes
             Charactr - char x = 'X'; --> 2 bytes
             Boolean - bool isHardworking = true; --> 1 bit
             String - string name = "Usman"; --> 2 bytes per character
             */

            // for float, writing F is neccesary after decimal number 
            // for double, writing D is optional
            // bonus: C# is a typesafe language which means a variable can't change its type across the code. An int variable can't be assigned a string

            /* Example of taking input
             //writing info for taking name
             Console.WriteLine("What's your name?");
             Console.Write("Name: ");
             
             //taking input by reading line
             string inp = Console.ReadLine();
             Console.WriteLine("Your name is " + inp + ".");
            */

            //Type Casting - conversion of variable type to another - Its types are:

            // 1) Implicit Casting - handled automatically by the compiler - a promotion table for char is following
            // char to int to long to float to double
            /*
             char x = 'x';
             int integar = x; //converted to integar following the promotion table
             Console.WriteLine(integar);
            */

            // 2) Explicit Casting - handled manually by the programmer
            /*
             int integar = (int) 'x'; //converted to integar
             Console.WriteLine(integar);
            */

            // Dating age checker
             // taking data from user and typecasting. also doing arithmetic operations
            /* 
             Console.Write("Your name: ");
             string name = Console.ReadLine();
             Console.Write("Your age: ");
             string age = Console.ReadLine();
             Console.WriteLine("Hi " + name + "! Your minimum dating age is: " + ((Convert.ToInt64(age)/2) + 7) );
            */

            // Operations are:
             // 1. Arithmetic - +, -, *, /
             // 2. Logical - Conjunction "&&", Disjunction "||", Negation "!"
             // 3. Assignment - =
             // 4. Comparison - >, <, ==, >=, !=

            /*
             Console.WriteLine("The arithmetic addition of 5 + 3 is: " + (5 + 3));
             Console.WriteLine("The logical disjunction (||) of true and false (true || false) is: " + (true || false));
             int x = 5; Console.WriteLine("The assignment operation of 5 into integar x (int x = 5) is: " + x);
             Console.WriteLine("The comparison of 420 != 69 is: " + (420 != 69));
            */

            //stops the console from closing
            Console.ReadLine();
        }
    }
}
