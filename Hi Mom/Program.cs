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


            //stops the console from closing
            Console.ReadLine();
        }
    }
}
