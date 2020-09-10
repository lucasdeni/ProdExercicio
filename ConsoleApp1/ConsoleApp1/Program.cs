using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto n, p, q;
            n = new Produto();
            p = new Produto();
            q = new Produto();

            Console.WriteLine("Entre com os produtos:");
            Console.Write("Nome: ");
            n.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            q.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double ValorTotalEstoque = (p.Preço * q.Quantidade);
            Console.WriteLine("Dados do produto: " + n.Nome + ", R$" + p.Preço + ", " + q.Quantidade + " unidades, total: R$" + ValorTotalEstoque);

            Console.Write("Digite o número a ser adicionado no estoque: ");
            int AdicionarProdutos = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            q.Quantidade = q.Quantidade + AdicionarProdutos;
            ValorTotalEstoque = (p.Preço * q.Quantidade);
            Console.WriteLine("Dados atualizados do produto: " + n.Nome + ", R$" + p.Preço + ", " + q.Quantidade + " unidades, total: R$" + ValorTotalEstoque);

            Console.Write("Digite o número a ser retirado no estoque: ");
            int RemoverProdutos = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            q.Quantidade = q.Quantidade - RemoverProdutos;
            ValorTotalEstoque = p.Preço * q.Quantidade;
            Console.WriteLine("Dados atualizados do produto: " + n.Nome + ", R$" + p.Preço + ", " + q.Quantidade + " unidades, total: R$" + ValorTotalEstoque);

            Console.ReadKey();
        }
    }
}
