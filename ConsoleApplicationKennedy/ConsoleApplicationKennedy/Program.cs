using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationKennedy
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable to store my full name
            string nameString = "";
          
            // variable to store my location
            string placeString = "";

            // get input
            Console.Write("User Name: ");
            nameString = Console.ReadLine();
            Console.Write("Location: ");
            placeString = Console.ReadLine();

            // two WriteLine statements that display as output previous 2 variables
            Console.WriteLine("Your Name is: " + nameString);
            Console.WriteLine("You are from: " + placeString);

            // variable containing today's date
            DateTime today = DateTime.Now;

            // output current date but not current time
            Console.Write("Today's Date: ");
            Console.WriteLine(today.ToString("d"));

            // variable: Christmas 2019 DateTime
            DateTime christmas = new DateTime(2019, 12, 25);

            // compute days till christmas
            TimeSpan daystill = christmas.Subtract(today);
                      
            // output number of days till christmas with label
            Console.Write("Days Till Christmas: ");
            Console.Write(daystill.TotalDays);

            // program example from section 2.1 from the book
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");

            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            // Pause the Program to avoid automatic termination
            Console.ReadLine();
        }
    }
}
