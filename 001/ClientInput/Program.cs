using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientInput
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine();
            Console.WriteLine(Calculate(userInput));
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadLine();
        }

        public static double Calculate(string userInput)
        {
            var solver = userInput.Split(' ');
            Console.WriteLine(solver[0]);

            var percent = Convert.ToDouble(solver[1]) / 12 / 100 + 1;
            var summ = Convert.ToDouble(solver[0]);

            for (var i=1; i <= Convert.ToInt32(solver[2]); i++)
            {
                summ *= percent;
            }
            return summ;
        }
    }
}
