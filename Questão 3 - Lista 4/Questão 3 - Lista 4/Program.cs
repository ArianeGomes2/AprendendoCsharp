using System;

namespace Questão_3___Lista_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira o elemento da " + i + " posição:");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Os números digitados foram:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vet[i]);
            }

            int maior = vet[0];
            int menor = vet[0];

            for (int i = 0; i < 10; i++)
            {
                if (vet[i] < menor)
                {
                    menor = vet[i];
                }else if(vet[i] > maior)
                {
                    maior = vet[i];
                }
            }

            if (menor % 2 == 0)
            {
                Console.WriteLine("O menor número digitado foi: " + menor + " é par");
            }
            else
            {
                Console.WriteLine("O menor número digitado foi: " + menor + " ele é impar");
            }

            if(maior % 2 == 0)
            {
                Console.WriteLine("O maior número digitado foi: " + maior + " ele é par");
            }
            else
            {
                Console.WriteLine("O maior número digitado foi: " + maior + " ele é ímpar");
            }
            
        }
    }
}
