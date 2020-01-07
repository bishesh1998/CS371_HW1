//////////////////////////////////////////////////////////////////////////////////
// HW 1 : EX 02
// CS371 - Whitworth University
// Originally outlined by: Bishesh Tuladhar
/////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //User Interface Menu
            Console.WriteLine("************** CALCULATOR ***************** ");
            Console.WriteLine("Operations Available : ");
            Console.WriteLine(("1. Addition"));
            Console.WriteLine(("2. Subtration"));
            Console.WriteLine(("3. Multiplication"));
            Console.WriteLine(("4. Division"));

            //Variables
            string x, y; //user input for the two number in string
            int a, b; //converted int of the user input string
            int ans; //answer 
            string math; //user input operation
            int op; //converted int of the user input operation

            string message, title; //string for the message box 

            do
            {                
                Console.Write("What operation should you like to perform ? (Enter any 0 to exit) : "); 

                math = Console.ReadLine(); //user input for the operation
                op = Convert.ToInt32(math);

                if (op == 1) //condition for addition
                {
                    Console.Write("Enter the first number : ");
                    x = Console.ReadLine();
                    Console.Write("Enter the second number : ");
                    y = Console.ReadLine();

                    a = Convert.ToInt32(x); //converting the first input
                    b = Convert.ToInt32(y); //converting the second input

                    ans = Add(a, b); //calling the function
                    message = "Answer = " + Convert.ToString(ans);
                    title = "Addition Answer";
                    MessageBox.Show(message, title); //message box
                }
                else if (op == 2) //condition for subtraction
                {
                    Console.Write("Enter the first number : ");
                    x = Console.ReadLine();
                    Console.Write("Enter the second number : ");
                    y = Console.ReadLine();

                    a = Convert.ToInt32(x); //converting the first input
                    b = Convert.ToInt32(y); //converting the second input

                    ans = Subtract(a, b); //calling the function
                    message = "Answer = " + Convert.ToString(ans);
                    title = "Subtraction Answer";
                    MessageBox.Show(message, title); //message box
                }
                else if (op == 3) //condition for multipication
                {
                    Console.Write("Enter the first number : ");
                    x = Console.ReadLine();
                    Console.Write("Enter the second number : ");
                    y = Console.ReadLine();

                    a = Convert.ToInt32(x); //converting the first input
                    b = Convert.ToInt32(y); //converting the second input

                    ans = Multiply(a, b); //calling the function
                    message = "Answer = " + Convert.ToString(ans);
                    title = "Multiplication Answer";
                    MessageBox.Show(message, title); //message box
                }
                else if (op == 4) //condition for division
                {
                    Console.Write("Enter the first number : ");
                    x = Console.ReadLine();
                    Console.Write("Enter the second number : ");
                    y = Console.ReadLine();

                    a = Convert.ToInt32(x); //converting the first input
                    b = Convert.ToInt32(y); //converting the second input

                    ans = Divide(a, b); //calling the function
                    message = "Answer = " + Convert.ToString(ans);
                    title = "Divison Answer";
                    MessageBox.Show(message, title); //message box
                }
                else
                {
                    if (op != 0)
                    {
                        Console.WriteLine("Invalid Input. Try Again");
                    }
                }
            } while (op != 0);
        }

        //Add function
        //Returms the sum of two numbers
        static int Add(int a, int b)
        {
            return a + b;
        }
        //Add function
        //Returms the difference of two numbers
        static int Subtract(int a, int b)
        {
            return a - b;
        }

        //Add function
        //Returms the product of two numbers
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        //Add function
        //Returms the division of two numbers
        static int Divide(int a, int b)
        {
            return a / b;
        }



    }
}
