using System;
using System.Runtime.Serialization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("\n*************** Calculadora ***************");

            Console.WriteLine("\nInsira o primeiro valor:");
            double valor1;
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira o segundo valor:");
            double valor2;
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação desejada");

            Console.WriteLine("\n(1)-Soma " + (" ") +
                "(2)-Subtração " + (" ") +
                "(3)-Multiplicação " + (" ") +
                "(4)-Divisão " + (" ") +
                "(5)-Elevado Ao Quadrado ");

            Console.WriteLine();
            
            double opcao;
            opcao = double.Parse(Console.ReadLine());

            double soma = 0;
            double subtracao = 0;
            double multiplicacao = 0;
            double divisao = 0;
            double quadrado1 = 0;
            double quadrado2 = 0;

            if (opcao == 1)
            {
                soma = valor1 + valor2;
                Console.WriteLine("A soma é = " + soma);

            }
            else if (opcao == 2)
            {
                subtracao = valor1 - valor2;
                Console.WriteLine("A subtração é = " + subtracao);
            }
            else if (opcao == 3)
            {
                multiplicacao = valor1 * valor2;
                Console.WriteLine("A multiplicação é = " + multiplicacao);
            }
             if (opcao == 4 && valor2 !=0)
            {
                
                divisao = valor1 / valor2;
                Console.WriteLine("A divisão é = " + divisao);

            }else if (opcao == 4 && valor2 == 0){
                Console.WriteLine("O valor não pode ter dividendo = 0");
            }
            
            if(opcao == 5)
            {
 
                quadrado1 = valor1 * valor1;
                quadrado2= valor2 * valor2;
                Console.WriteLine("Os números ao quadrado são : " + quadrado1  + " e " +  quadrado2);
            }


        }
    }
}
