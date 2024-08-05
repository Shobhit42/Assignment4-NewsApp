using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_NewsApp
{
    public static class ConsoleHelper
    {
        public static void DisplayCategoryOptions()
        {
            Console.WriteLine("Select Category from following options");
            Console.WriteLine("[1]. Business");
            Console.WriteLine("[2]. Entertainment");
            Console.WriteLine("[3]. General");
            Console.WriteLine("[4]. Skip");
        }

        public static void DisplayCountryOptions()
        {
            Console.WriteLine("Select Country from following options");
            Console.WriteLine("[1]. India");
            Console.WriteLine("[2]. USA");
            Console.WriteLine("[3]. China");
            Console.WriteLine("[4]. Skip");
        }

        public static int GetInputInt()
        {
            var frequency = 3;
            int inputNumber = default(int);
            while (frequency > 0)
            {
                try
                {
                    bool isParsed = int.TryParse(Console.ReadLine(), out inputNumber) && inputNumber > 0 && inputNumber < int.MaxValue;
                    if (isParsed == true) return inputNumber;
                    else Console.WriteLine("** Invalid Input **");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            if (frequency < 1) Environment.Exit(0);
            return inputNumber;
        }
    }
}
