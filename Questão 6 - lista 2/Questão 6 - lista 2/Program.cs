using System;
using System.Globalization;

namespace Questão_6___lista_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;

            while (number <= 200) {
     
                    if (number % 2 == 0)
                    {
                        Console.WriteLine(number);
                    }
                number++;

            }
                
        }    
    }
}