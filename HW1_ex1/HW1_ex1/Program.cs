//////////////////////////////////////////////////////////////////////////////////
// HW 1 : EX 01
// CS371 - Whitworth University
// Originally outlined by: Bishesh Tuladhar
/////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There");
            string username = System.Environment.UserName; //retriving the username from the system
            Console.WriteLine("I see you're known to the system as {0}",username);
            Console.Write("What do you prefer to be called ? : "); //prompting user for a name
            username = Console.ReadLine();
            Console.Write("OK {0}. How old are you ? : ",username); //prompting user for age
            string age;
            age = Console.ReadLine();
            int value = Convert.ToInt32(age); //converting the age string to integer

            Console.Clear();

            //Checking the condition of minority
            if (value > 18) //conditiong for major
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else //conditiong for minor
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("Hello {0}",username);

            //Displaying a danger message box if the user is minor
            if (value < 18)
            {
                string message = "DANGER " + username + " ! DANGER! ";
                string title = "DANGER";
                Console.WriteLine(message, title);
                MessageBox.Show(message, title); //message box
                Console.Beep(); //console beep
            }
        }
    }
}
