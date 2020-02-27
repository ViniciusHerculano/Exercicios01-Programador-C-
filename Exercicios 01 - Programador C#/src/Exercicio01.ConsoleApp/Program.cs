using System;

namespace Exercicio01.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = ""; 
            var preco = 0.0f;
            var percentual = 0.0f;

            Console.WriteLine($"{calcularDesconto(nome, preco, percentual)}");
        }

        private static string calcularDesconto (string nomeProd, float precoUnd, float percentualDesconto)
        {
            Console.Write($"Nome do produto: ");
            nomeProd = Console.ReadLine();
            Console.Write($"Preço: ");
            precoUnd = float.Parse(Console.ReadLine());
            Console.Write($"Percentual de desconto (Sem o %): ");
            percentualDesconto = float.Parse(Console.ReadLine());
            return ($"Produto: {nomeProd} | desconto de : R${Convert.ToString(precoUnd * percentualDesconto/100)}");
        }
    }
}
