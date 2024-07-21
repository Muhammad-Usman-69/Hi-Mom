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
             Integar - int num = 12; --> 4 bytes | Stores whole numbers from -2,147,483,648 to 2,147,483,647
             Long - long num = 123; --> 8 bytes | Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
             Floating Point Number - float thisF; --> 4 bytes | Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
             Double - double var = 5.73D; --> 8 bytes | Stores fractional numbers. Sufficient for storing 15 decimal digits
             Character - char x = 'X'; --> 2 bytes | Stores true or false values
             Boolean - bool isHardworking = true; --> 1 bit | Stores a single character/letter, surrounded by single quotes
             String - string name = "Usman"; --> 2 bytes per character | Stores a sequence of characters, surrounded by double quotes
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
             int integar = (int) 10.5; //converted from float to integar
             Console.WriteLine(integar);

             // can also do it using methods
             int var = Convert.ToInt32(15.35);  
             Console.WriteLine(var);
            */


            //stops the console from closing
            Console.ReadLine();
        }
    }
}
