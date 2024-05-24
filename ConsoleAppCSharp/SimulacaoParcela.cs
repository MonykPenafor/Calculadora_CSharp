using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharp
{
	public class SimulacaoParcela
	{
		public int Quantidade { get; }
		public decimal ValorParcela { get; }
		public decimal ValorTotal { get { return ValorParcela * Quantidade; } }

		public decimal TotalDeJuros { get; }

		public DateTime Vencimento { get; }
		public SimulacaoParcela(int quantidade, decimal valorParcela, decimal totalDeJuros, DateTime vencimento)
		{
			Quantidade = quantidade;
			ValorParcela = valorParcela;
			TotalDeJuros = totalDeJuros;
			Vencimento = vencimento;

		}
	}

}
