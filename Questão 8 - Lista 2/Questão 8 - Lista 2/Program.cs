using System;

namespace Questão_8___Lista_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            int divisor;
            int numeroDivisor;

            while (number <= 200)
            {
                divisor = 0;
                numeroDivisor = 0;

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        divisor++;
                        numeroDivisor = number;
                    }

                }

                if (divisor == 2)
                {
                    Console.WriteLine(numeroDivisor);
                }

                number++;

            }
        }
    }
}
