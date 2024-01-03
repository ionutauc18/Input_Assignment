using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking the user to type a number
            Console.WriteLine("Please type a whole number:");
            // Converting the user input in to an integer
            int number = Convert.ToInt32(Console.ReadLine());
            // Printing the user imput
            Console.WriteLine(number);
            // Printing the text file back to the user
            using (StreamWriter file = new StreamWriter(@"C:\Users\ionut\Dropbox\PC\Desktop\C# and .NET Framework - Part 2\File_Text_IO\IO.txt", true))
            {
                file.WriteLine(number);
            }
            // Keeping the console window open until a key is pressed
            Console.ReadLine();
        }
    }
}
