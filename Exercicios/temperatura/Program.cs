using System;

namespace temperatura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sucesso;
            Console.WriteLine("Temperatura?");
            sucesso = int.TryParse(Console.ReadLine(), out int celsius);
        volta:
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta;
            }

            double farenheit = celsius * 1.8 + 32;
            Console.WriteLine("temperatura em fahrenheit e: " + farenheit);
            Console.WriteLine("aperte enter para sair");
            Console.ReadLine();
        }
    }
}
    