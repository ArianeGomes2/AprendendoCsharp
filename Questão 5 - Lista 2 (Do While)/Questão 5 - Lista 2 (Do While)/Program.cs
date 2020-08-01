using System;

namespace Questão_5___Lista_2__Do_While_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int divisor;

            do
            {
                Console.WriteLine("Digite um valor inteiro (para encerrar digite um valor primo):");
                number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine(number + " é par!");
                }
                else
                {
                    Console.WriteLine(number + " é ímpar!");
                }

                divisor = 0;

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        divisor++;
                    }
                }
                if (divisor == 2)
                {
                    Console.WriteLine(number + " é primo, por isso o programa será encerrado");
                }
            } while (divisor != 2);
        }
    }
}