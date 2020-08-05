using System;

namespace Questão_1___lista_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a contidade de elementos:");
            int elements = int.Parse(Console.ReadLine());
            int[] vet = new int[elements];

            for (int i = 1; i <= elements; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }for (int i = 1; i <= elements; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}
