using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_8_Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. input 20 numbers and determine the sum

            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.Write("Enter number: ");
                int Number = int.Parse(Console.ReadLine());
                sum = sum + Number;
            }
            Console.WriteLine("sum = " + sum);
        }
    }
}
