using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp1
{
	public class Produto
	{
		public string Nome;
		public double Preço;
		public int Quantidade;

		public double ValorTotalEmEstoque()
		{
			return Preço * Quantidade;
		}
		public void AddProdutos(int quantidade)
		{
			Quantidade += quantidade;
		}
		public void SubProdutos(int quantidade)
		{
			Quantidade -= quantidade;
		}
		public override string ToString()
		{
			return Nome
				+ ", $"
				+ Preço.ToString("F2", CultureInfo.InvariantCulture)
				+ ", "
				+ Quantidade
				+ " unidades, Total: $ "
				+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
