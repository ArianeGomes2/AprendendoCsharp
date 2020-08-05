using System;

namespace Questão_2____Lista_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de elementos:");
            int n = int.Parse(Console.ReadLine());
            int[] vet = new int[n];
            int maior = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o elemento de índice" + "{" + i + "}:");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Os números digitados foram:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vet[i]);
            }

            for (int i = 0; i < n; i++)
            {               
                if (vet[i] > maior)
                {
                    maior = vet[i];
                }
            }

            Console.WriteLine("O maior número digitado foi: " + maior);

        }
    }
}