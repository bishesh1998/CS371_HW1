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
            string username = System.Environment.UserName;
            Console.WriteLine("I see you're known to the system as {0}",username);
            Console.Write("What do you prefer to be called ? : ");
            username = Console.ReadLine();
            //int age;
            Console.Write("OK {0}. How old are you ? : ",username);
            string age;
            age = Console.ReadLine();
            int value = Convert.ToInt32(age);

            Console.Clear();

            //Checking the condition of minority
            if (value > 18)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            Console.WriteLine("Hello {0}",username);

            if (value < 18)
            {
                string message = "DANGER " + username + " ! DANGER! ";
                string title = "DANGER";
                Console.WriteLine(message, title);
                MessageBox.Show(message, title);
                Console.Beep();
            }
        }
    }
}
