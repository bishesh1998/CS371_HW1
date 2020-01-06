using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int key = 1;
            do
            {
                Console.WriteLine("************** CALCULATOR ***************** ");
                Console.WriteLine("Operations Available : ");
                Console.WriteLine(("1. Addition"));
                Console.WriteLine(("2. Subtration"));
                Console.WriteLine(("3. Multiplication"));
                Console.WriteLine(("4. Division"));
                string math;

                Console.WriteLine("What operation should you like to perform ? (Enter any 0 to exit)"); 

                math = Console.ReadLine(); //user input for the operation
                int op = Convert.ToInt32(math);
                
                string x, y; //user input for the two 
                Console.WriteLine("Enter the first number : ");
                x = Console.ReadLine();
                Console.WriteLine("Enter the second number : ");
                y = Console.ReadLine();

                int a, b;

                a = Convert.ToInt32(x);
                b = Convert.ToInt32(y);

                int ans;

                if (op == 1)
                {
                    ans = Add(a,b)
                }
                else if (op == 2)
                {
                    ans = Subtract(a, b)
                }
                else if (op == 3)
                {
                    ans = Multiply(a, b)
                }
                else if (op == 2)
                {
                    ans = Divide(a, b)
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again");
                }
            } while (key != 0);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Divide(int a, int b)
        {
            return a / b;
        }



    }
}
