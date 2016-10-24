using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Lab1
    {
        static void Main(string[] args)
        {
            while (true) //initiates an infinite loop to keep prompting the user if they wish to continue (yes or no
            {
                //Promting the user to enter in length, width and height and initializing the variables in the process
                Console.WriteLine("Please enter the Length of the room.");

                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the width of the room.");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the height of the room.");
                double height = Convert.ToDouble(Console.ReadLine());
                ////////////////////////////////////////////////////////////////////////////

                //calculating area, perimeter and volume
                double area = length * width;
                double perimeter = 2 * length + 2 * width;
                double volume = area * height;
                ///////////////////////////////////////////////////////////////////////////

                //printing out the perimeter and area values
                Console.WriteLine("The area of your room is:{0}", area);
                Console.WriteLine("The perimeter of your room is:{0}", perimeter);
                Console.WriteLine("The volume of your room is:{0}", volume);
                ////////////////////////////////////////////////////////////////////////////

                // Keeps the console window open in debug mode-running into this issue with Visual Studio for some reason
               
                Console.WriteLine("Would you like to continue? (Press any key for yes or N for no)");
                string answer = Console.ReadLine();//prompts user if they want to continue
                if (answer == "N")
                {
                    break;
                }
            }
        }
    }
}
