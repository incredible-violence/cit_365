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

            // user input banner
            BannerMessage("Name and Location Section");

            // get input
            Console.Write("User Name: ");
            nameString = Console.ReadLine();
            Console.Write("Location: ");
            placeString = Console.ReadLine();

            // two WriteLine statements that display as output previous 2 variables
            Console.WriteLine("Your Name is: " + nameString);
            Console.WriteLine("You are from: " + placeString);

            // welcome message
            BannerMessage("Current Date but not Time");

            // variable containing today's date
            DateTime today = DateTime.Now;

            // output current date but not current time
            Console.Write("Today's Date: ");
            Console.WriteLine(today.ToString("d"));
            
            // christmas banner
            BannerMessage("Christmas Calculator");

            // variable: Christmas 2019 DateTime
            DateTime christmas = new DateTime(2019, 12, 25);

            // compute days till christmas
            TimeSpan daystill = christmas.Subtract(today);

            // make sure christmas has not passed
            if (daystill.TotalDays < 0)
            {
                Console.WriteLine("Christmas has passed this year");
                christmas = christmas.AddYears(1);
                Console.WriteLine("Next Christmas is " + christmas.ToString("d"));
                TimeSpan newyear = christmas.Subtract(today);
                Console.WriteLine("Days Till Christmas: " + newyear.TotalDays);
            }
            else
            {
                Console.WriteLine("Days Till Christmas: " + daystill.TotalDays);
            }

            // for testing purposes
            BannerMessage("Demonstration of Error Handling");

            // new day, specifically after christmas 2019
            DateTime testday = new DateTime(2019, 12, 28);

            TimeSpan teststill = christmas.Subtract(testday);

            Console.WriteLine("Date After Christmas: " + testday.ToString("d"));
            Console.WriteLine("If negative, add a year to christmas variable: " + teststill.TotalDays);

            if (teststill.TotalDays < 0)
            {
                Console.WriteLine("Christmas has passed this year");
                christmas = christmas.AddYears(1);
                Console.WriteLine("Next Christmas is " + christmas.ToString("d"));
                TimeSpan newyear = christmas.Subtract(testday);
                Console.WriteLine("Days Till Christmas: " + newyear.TotalDays);
            }
            else
            {
                TimeSpan dayTest = christmas.Subtract(testday);
                Console.WriteLine("TEST: " + dayTest.TotalDays);
                Console.WriteLine(dayTest.TotalDays);
            }
           
            // program example from section 2.1 from the book
            BannerMessage("Stuff From the Book - Enhanced");

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

        public static void BannerMessage(string label)
        {
            // banner message
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("-        " + label + "       -");
            Console.WriteLine("----------------------------------------------------");
        }

        /*
         * Method to Demonstrate Steps 2 and 3 from the Assignment 
         */
        void StepsTwoAndThree()
        {

        }

        /*
         * Method to Demonstrate Step 4 from the Assignment 
         */
        void StepFour()
        {

        }

        /*
         * Method to Demonstrate Step 5 from the Assignment 
         */
        void StepFive()
        {

        }

        /*
         * Method to Demonstrate Steps 6 and 7 from the Assignment 
         */
        void StepsSixAndSeven()
        {

        }
    }
}
