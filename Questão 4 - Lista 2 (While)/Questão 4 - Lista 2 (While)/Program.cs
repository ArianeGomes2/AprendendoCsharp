using System;

namespace Questão_4___Lista_2__While_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;

            while (number != 0)
            {
                Console.WriteLine("Digite um valor inteiro:");
                number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine(number + " é par!");
                }
                else
                {
                    Console.WriteLine(number + " é ímpar!");
                }

            }
        }
    }
}
