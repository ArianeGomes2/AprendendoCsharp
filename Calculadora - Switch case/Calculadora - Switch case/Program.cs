using System;
using System.Linq.Expressions;

namespace Calculadora___Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a operação desejada" +
                " 1- Soma" +
                " 2- Subtração" +
                " 3- Multiplicação" +
                " 4- Divisão" +
                " 0- Sair do Programa ");
            int opcao = int.Parse(Console.ReadLine());
            int result;
            

            switch (opcao) { 
                case 1:
                result = valor1 + valor2;
                    Console.WriteLine("O resultado da soma é: " + result);
                break;
            case 2:
                result = valor1 - valor2;
                    Console.WriteLine("O resultado da subtração é: " + result);
                    break;
            case 3:
                result = valor1 * valor2;
                    Console.WriteLine("O resultado da multiplicação é: " + result);
                    break;
            case 4:
                    if (valor2 == 0)
                    {
                        Console.WriteLine("Você não pode dividir um algorismo por zero");
                    }
                    else
                    {
                        result = valor1 / valor2;
                        Console.WriteLine("O resultado da divisão é: " + result);
                    }
                break;
            default:
               Console.WriteLine("Programa Encerrado!");
                break;


            }
        }
    }

}

