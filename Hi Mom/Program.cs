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
             Floating Point Number - float this; --> 4 bytes
             Double - double that; --> 8 bytes
             Charactr - char x = 'X'; --> 2 bytes
             Boolean - bool isHardworking = true; --> 1 bit
             String - string name = "Usman"; --> 2 bytes per character
             */

            //writing info for taking name
            Console.WriteLine("What's your name?");
            Console.Write("Name: ");

            //taking input by reading line
            string inp = Console.ReadLine();
            Console.WriteLine("Your name is " + inp + ".");

            //stops the console from closing
            Console.ReadLine();
        }
    }
}
