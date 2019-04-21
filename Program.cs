using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            string a;

            Console.WriteLine("Digite um numero: ");
            a = Console.ReadLine();
            num1 = int.Parse(a);
         

            if (num1 == 1)
            {
                Console.WriteLine("Domingo");
            }
            if (num1 == 2)
            {
                Console.WriteLine("Segunda");
            }
            if (num1 == 3)
            {
                Console.WriteLine("Terca");
            }
            if (num1 == 4)
            {
                Console.WriteLine("Quarta");
            }
            if (num1 == 5)
            {
                Console.WriteLine("Quinta");
            }
            if (num1 == 6)
            {
                Console.WriteLine("Sexta");
            }
            if (num1 == 7)
            {
                Console.WriteLine("Sabado");
            }

        }
    }
}
