using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    delegate double BinaryOperator(double op1, double op2);

    class Program
    {
        static double Add(double x, double y) { return x + y; }
        static double Subtract(double x, double y) { return x - y; }
        static double Multiply(double x, double y) { return x * y; }
        static double Divide(double x, double y) { return x / y; }
        static double Mod(double x, double y) { return x % y; }
        static double Square(double x, double y) { return Math.Pow(x, y); }

        static Dictionary<char, BinaryOperator> operators = new Dictionary<char, BinaryOperator>()
        {
            { '+', Add },
            { '-', Subtract },
            { '*', Multiply },
            { '/', Divide },
            { '%', Mod },
            { '^', Square }
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Возможные операции с ДВУМЯ числами:\n \"+\", \"-\", \"*\", \"/\", \"%\", \"^\".");
                Console.WriteLine("Введите 0 или нажмите Enter, если хотите выйти.");

                //Ex.: 15 * 4
                var input = Console.ReadLine().Split();
                if (input[0] == "0" | input[0] == "")
                    Environment.Exit(0);

                double x = int.Parse(input[0]);
                BinaryOperator binaryOperator = operators[input[1][0]];
                double y = int.Parse(input[0 + 2]);

                double result = binaryOperator(x, y);
                Console.WriteLine("Результат: {0}\nНажмите любую клавишу чтобы продолжить...", result);
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
