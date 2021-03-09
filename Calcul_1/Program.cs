using System;

namespace Calcul_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo, dies ist mein erster Taschenrechner)");
            String myString = Console.ReadLine();
            Console.WriteLine(myString);


            char again = 'l';
            while (again == 'l')
            {
                double x;
                double y;
                double c;
                double total;
                char oper;

                Console.WriteLine("erste Nummer");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Operator");
                oper = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("zwiete Nummer");
                y = Convert.ToDouble(Console.ReadLine());

                if (oper == '+')
                {
                    total = x + y;
                    Console.WriteLine("Summe  " + total + ".");
                }
                else if (oper == '-')
                {
                    total = x - y;
                    Console.WriteLine("Unterschied  " + total + ".");
                }
                else if (oper == '*')
                {
                    total = x * y;
                    Console.WriteLine("Multiplikation  " + total + ".");
                }
                else if (oper == '/')
                {
                    if (y != 0)
                    {
                        total = x / y;
                        Console.WriteLine("Teilung  " + total + ".");
                    }
                    else
                    {
                        Console.WriteLine("Kann nicht durch 0 geteilt werden");
                    }
                }
                else if (oper == '^')
                {
                    c = Math.Pow(x, y);
                    Console.WriteLine("Ponzierung  " + c + ".");
                }
                else
                {
                    Console.WriteLine("unbekannter Betreibe");
                }
                Console.WriteLine("Vorgehen? klicken 'l'");
                again = Convert.ToChar(Console.ReadLine());
            }

        }
    }
}
