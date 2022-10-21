using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Check(num, 7);
            Check(num, 13);
            Check(num, 17);
            Console.ReadLine();


        } //Main

        static void Check(int n, int d)
        {
            if (n < 0 || d < 0)
                return;

            if (n % d == 0)
            {
                Console.WriteLine($"{n} is divisible by {d}");
            }
            else
            {
                Console.WriteLine($"{n} is not divisible by {d}");
            }
        }
    }// Class
}//Namespace
