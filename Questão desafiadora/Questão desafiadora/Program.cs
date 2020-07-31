using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Questão_desafiadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("Digite o pimeiro valor inteiro:");
                int valor1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor inteiro:");
                int valor2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Escolha a opção desejada: " +
                    "1- Par" +
                    "2- Ímpar" +
                    "3- Primo" +
                    "0- Sair do Programa");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    if (valor1 % 2 == 0)
                    {
                        Console.WriteLine(valor1 + " é par");
                    }
                    if (valor2 % 2 == 0)
                    {
                        Console.WriteLine(valor2 + " é par");
                    }
                }
                if (opcao == 2)
                {
                    if (valor1 % 2 != 0)
                    {
                        Console.WriteLine(valor1 + " é ímpar");
                    }
                    if (valor2 % 2 != 0)
                    {
                        Console.WriteLine(valor2 + " é ímpar");
                    }
                }
                
                if (opcao == 3)
                {
                    int divisor1 = 0;
                    for (int i =1; i <= valor1; i++)
                    {
                        if(valor1 % i == 0)
                        {
                            divisor1++;
                        } 
                    }
                    if (divisor1 == 2)
                    {
                        Console.WriteLine(valor1 + " é primo");
                    }
                    else if (divisor1 != 2)
                    {
                        Console.WriteLine(valor1 + " não é primo");

                    }

                    int divisor2 = 0;
                    for (int i = 1; i <= valor2; i++)
                    {
                        if (valor2 % i == 0)
                        {
                            divisor2++;
                        }
                    }
                    if (divisor2 == 2)
                    {
                        Console.WriteLine(valor2 + " é primo");
                    }
                    else if (divisor2 != 2)
                    {
                        Console.WriteLine(valor2 + " não é primo");

                    }

                }
                
                if (opcao != 1 && opcao != 2 && opcao != 3 && opcao != 0)
                {
                    Console.WriteLine("Valor inválido");
                }

            } while (opcao != 0);

            Console.WriteLine("O programa foi encerrado");
        }
    }
}

