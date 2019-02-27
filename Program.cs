using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, number3;
            

            Console.Write("Price #1: ");
                number1 = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

            Console.Write("Price #2: ");
                number2 = Math.Round (Convert.ToDouble(Console.ReadLine()), 2);

            Console.Write("Price #3: ");
                number3 = Math.Round (Convert.ToDouble(Console.ReadLine()), 2);

            double result = Math.Round( (number1 + number2 + number3) / 3, 2);
            Console.WriteLine("The average of {0}, {1}, {2} is {3} ", number1, number2, number3, result);

            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("The largest price is " + number1);
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine("The largest price is " + number2);
            }
            else if (number3 > number1 && number3 > number2)
            {
                Console.WriteLine("The largest price is " + number3);
            }

            if (number1 < number2 && number1 < number3)
            {
                Console.WriteLine("The smallest price is " + number1);
            }
            else if (number2 < number1 && number2 < number3)
            {
                Console.WriteLine("The smallest price is " + number2);
            }
            else if (number3 < number1 && number3 < number2)
            {
                Console.WriteLine("The smallest price is " + number3);
            }

            double currency = number1 + number2 + number3;

            Console.WriteLine("US: $" + currency);
            Console.WriteLine("Swedish: " + currency * 10 + " kr");
            Console.WriteLine("Japanese: ¥" + Convert.ToInt32(currency));
            Console.WriteLine("Thai: " + currency);

            Console.Read();



        }
    }
}
