using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com os produtos:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preço = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do produto: " + p);

            Console.Write("Digite o número a ser adicionado no estoque: ");
            int AdicionarProdutos = int.Parse(Console.ReadLine());
            p.AddProdutos(AdicionarProdutos);
            Console.WriteLine("Dados atualizados do produto: " + p);

            Console.Write("Digite o número a ser retirado no estoque: ");
            int RemoverProdutos = int.Parse(Console.ReadLine());
            p.SubProdutos(RemoverProdutos);
            Console.WriteLine("Dados atualizados do produto: " + p);

            Console.ReadKey();
        }
    }
}
