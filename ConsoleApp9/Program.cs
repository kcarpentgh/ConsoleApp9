using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int intinput1 = 0;
            string stringinput1 = "";
            int intinput2 = 0;
            string stringinput2 = "";
            string operatorinput = "";
            int answer = 0;
            int remainder = 0;

            while (operatorinput != "exit")
            {
                Console.WriteLine("Please input a number.");
                stringinput1 = Console.ReadLine();
                intinput1 = Convert.ToInt32(stringinput1);

                Console.WriteLine("Please input a number.");
                stringinput2 = Console.ReadLine();
                intinput2 = Convert.ToInt32(stringinput2);

                Console.WriteLine("Please input the desired math operation.");
                operatorinput = Console.ReadLine();

                switch (operatorinput)
                {
                    case "+":
                        answer = intinput1 + intinput2;
                        Console.WriteLine("You chose addition. Here is your answer: " + answer);
                        break;

                    case "-":
                        answer = intinput1 - intinput2;
                        Console.WriteLine("You chose subtraction. Here is your answer: " + answer);
                        break;

                    case "/":
                        answer = intinput1 / intinput2;
                        Console.WriteLine("You chose division. Here is your answer: " + answer);
                        break;
                    case "*":
                        answer = intinput1 * intinput2;
                        Console.WriteLine("You chose multiplication. Here is your answer: " + answer);
                        break;
                    case "%":
                        answer = intinput1 / intinput2;
                        remainder = intinput1 % intinput2;
                        Console.WriteLine($"You chose division with remainder. Here is your answer: {answer} remainder {remainder}");
                        break;

                }

                Console.ReadKey();
            }
        }
    }
}
