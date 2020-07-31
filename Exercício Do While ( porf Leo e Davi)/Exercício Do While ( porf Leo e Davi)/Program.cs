using System;

namespace Exercício_Do_While___porf_Leo_e_Davi_
{
    
        class Program
        {
            static void Main(string[] args)
            {

                int numero = -1;

                do
                {
                    Console.WriteLine("Digite um número inteiro para verificar se ele é ímpar ou par ou o número zero para encerrar o programa");
                    numero = int.Parse(Console.ReadLine());
                    if (numero == 0)
                    {
                        Console.WriteLine("Você digitou zero, programa encerrado!");
                    }
                    else if (numero % 2 == 0)
                    {
                        Console.WriteLine("O numero " + numero + " é par");
                    }
                    else
                    {
                        Console.WriteLine("O numero " + numero + " é ímpar ");
                    }

                } while (numero != 0);

            }
        }
    }

