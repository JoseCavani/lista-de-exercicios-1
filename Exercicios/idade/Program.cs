using System;

namespace Idade.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sucesso;
            Console.WriteLine("Seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Idade?");
        volta1:
            sucesso = int.TryParse(Console.ReadLine(), out int idade);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta1;
            }
            Console.WriteLine($"{nome}, VOCÊ JÁ VIVEU {idade * 365} DIAS.");
            Console.WriteLine("aperete enter para sair");
            Console.ReadLine();
        }
    }
}
