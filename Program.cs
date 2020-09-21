using System;

namespace Diagnostico
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int opcao = 0;

            Console.WriteLine("Digite um numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Somar digite 1");
            Console.WriteLine("Subtrair digite 2");
            Console.WriteLine("Dividir digite 3");
            Console.WriteLine("Multiplicar digite 4");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine(num1 + num2);
            }

            if (opcao == 2)
            {
                Console.WriteLine(num1 - num2);
            }

            if (opcao == 3)
            {
                Console.WriteLine(num1 / num2);
            }

            if (opcao == 4)
            {
                Console.WriteLine(num1 * num2);
            }
            
        }
    }
}
