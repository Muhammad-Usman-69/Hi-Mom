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
            //*/

            //Type Casting - conversion of variable type to another - Its types are:

            // 1) Implicit Casting - handled automatically by the compiler - a promotion table for char is following
            // char to int to long to float to double
            /*
             char x = 'x';
             int integar = x; //converted to integar following the promotion table
             Console.WriteLine(integar);
            //*/

            // 2) Explicit Casting - handled manually by the programmer
            /*
             int integar = (int) 10.5; //converted from float to integar
             Console.WriteLine(integar);

             // can also do it using methods
             int var = Convert.ToInt32(15.35);  
             Console.WriteLine(var);
            //*/

            // Dating age checker
            // taking data from user and typecasting. also doing arithmetic operations and string interpolcation
            /*
             Console.Write("Your name: ");
             string name = Console.ReadLine();
             Console.Write("Your age: ");
             string age = Console.ReadLine();
             Console.WriteLine($"Hi {name}! Your minimum dating age is: " + ((Convert.ToInt64(age)/2) + 7) );
            //*/

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
            //*/

            //stops the console from closing

            // Math Class - it has many methods that allows you to perform mathematical tasks on numbers.
            /*
             double x = Math.Sqrt(90);
             Console.WriteLine(x);
            //*/

            // String Methods
            /*
             string str = "Hi Mom!";
             Console.WriteLine(str.Length); // return length of string
             Console.WriteLine(str.ToUpper()); // convert to uppercase
             Console.WriteLine(str + " I am good"); // concatinate string
             Console.WriteLine(String.Concat(str, " I am good")); // concatinate string using method
             Console.WriteLine($"{str} I am good "); // string interpolation
             Console.WriteLine(str[0]); // returns the char of string according to index
             Console.WriteLine(str.IndexOf("Mom")); // returns the index of given occurance "Mom"
             Console.WriteLine(str.Substring(3)); // returns the string after index 3
             Console.WriteLine($"\"{str}\""); // return escape sequence characters like " etc
            //*/

            /*
             int age = 17;
             bool lincense = false;

             if (age > 18 && lincense == true)
             {
                 Console.WriteLine("You can drive");
             }
             else if (age > 18 && lincense == false)
             {
                 Console.WriteLine("You do not have the required lincense to drive");
             }
             else
             {
                 Console.WriteLine("You can't drive because of less age");
             }
            //*/

            /*
            int day = 5;

            //The value of the expression (day) is compared with the values of each case
            switch (day)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Tumhare dimag me bhusa bhara ha");
                    break;
            }
            //*/

            Console.ReadLine();
        }
    }
}