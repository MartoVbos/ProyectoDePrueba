using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese num 1:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese num 2:");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("MENU");
                Console.WriteLine("1.Sumar");
                Console.WriteLine("2.Restar");
                Console.WriteLine("3.Multiplicar");
                string opc = Console.ReadLine();
                if (opc == "1")
                {
                    Console.WriteLine(" {0} + {1} = {2} ", num1, num2, num1 + num2);
                }
                if (opc == "2")
                {
                    Console.WriteLine(" {0} - {1} = {2} ", num1, num2, num1 - num2);
                }
                if (opc == "3")
                {
                    Console.WriteLine(" {0} * {1} = {2} ", num1, num2, num1 * num2);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error, " + ex.Message);
            }
            
            
            Console.ReadKey();
        }
    }
}
