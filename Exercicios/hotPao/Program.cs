using System;

namespace hotPao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double valorPao = 0.12;
            const double valorBroa = 1.50;
            bool sucesso;
            Console.WriteLine("digite quantos paes foram vendidos");
        volta1:
            sucesso = float.TryParse(Console.ReadLine(), out float vendasPaes);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta1;
            }
            double totalPao = vendasPaes * valorPao;

            Console.WriteLine("digite quantos broa foram vendidos");
        volta2:
            sucesso = float.TryParse(Console.ReadLine(), out float vendasBroa);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta2;
            }
            double totalbroa = vendasBroa * valorBroa;

            double total = totalbroa + totalPao;

            Console.WriteLine($"total = {total} e para colocar na poupança = {total * 0.1}");
            Console.WriteLine("digite enter para sair");
            Console.ReadLine();
        }
    }
}
