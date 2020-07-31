using System;

namespace Questão_4___Lista_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.WriteLine("Digite um número inteiro:");
                number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("O número " + number + " é par");
                }else
                {
                    Console.WriteLine("O número " + number + " é impar");
                }

            } while (number != 0);
        }
    }
}
