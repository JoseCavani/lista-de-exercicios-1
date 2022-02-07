using System;

namespace salario.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sucesso;
            Console.WriteLine("digite o salario");
        volta1:
            sucesso = float.TryParse(Console.ReadLine(), out float salario);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta1;
            }
            Console.WriteLine($"salario inicial : {salario}, salario com aumento : {salario + salario * 0.15:F2}, salario com imposto : {salario - (salario + salario * 0.15) * 0.08:F2}.\ndigite enter para sair");
            Console.ReadLine();
        }
    }
}
