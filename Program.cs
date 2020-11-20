using System;

namespace SequenciaCentena
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;

            Console.WriteLine("Exibindo os 100 primeiros números naturais não nulos...");
            Console.WriteLine();
            while(contador <= 100)
            {
                Console.Write($"{contador} ");
                contador++;
            }
        }
    }
}
