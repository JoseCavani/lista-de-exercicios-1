using System;

namespace Terreno.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sucesso;
            Console.WriteLine("Digite o primerio lado");
        volta1:
            sucesso = float.TryParse(Console.ReadLine(), out float n1);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta1;
            }
        volta3:
            Console.WriteLine("digite o segundo numero");
            sucesso = float.TryParse(Console.ReadLine(), out float n2);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta3;
            }
            float area = n1 * n2;
            Console.WriteLine($"area do terreno e de : {area}");
            Console.WriteLine($"aperte enter para sair");
            Console.ReadLine();

        }
    }
}
