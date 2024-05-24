using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharp
{
	public class Calculadora
	{

		public bool EhPar(int numero)
		{
			if (numero % 2 == 0)
				return true;
			return false;
		}

		public decimal CalcularTotalJurosSimples(decimal valorDaParcela, decimal taxa)
		{
			decimal total = valorDaParcela * taxa/100;
			return total;

		}

		public int CalcularMaximoDivisorComum(int[] numeros)
		{
			var maior = ConsultarMaiorNumeroExistente(numeros);
			var mdc = 0;

			for (int n = 1; n <= maior; n++) 
			{
				var divisores = 0;

				for (int i = 0; i < numeros.Length; i++) 
				{
					if (numeros[i] % n == 0)
						divisores++;
				}

				if (divisores == numeros.Length)
					mdc = n;
			}

			return mdc;
		}

		private int ConsultarMaiorNumeroExistente(int[] numeros)
		{
			var maior = numeros[0];

			for (int n = 1; n < numeros.Length; n++)
			{
				if (numeros[n] > maior)
					maior = numeros[n];
			}

			return maior;
		}

		public decimal CalcularValorMontanteComJurosCompostos(decimal parcela, decimal taxa, int meses)
		{
			//M = C * (1 + i)^t

			decimal resultado = parcela * Convert.ToDecimal(Math.Pow((double)(1 + taxa/100), meses));

			return Math.Round(resultado, decimals: 2);

		}

		//public List<SimulacaoParcela> CalcularSimulacaoDeFinanciamentos(decimal valorFinanciamento, decimal taxa, int parcelas)
		//{
		//	var lista = new List<SimulacaoParcela>();

		//	for (int parcela = 0; parcela < parcelas; parcela++) 
		//	{
		//		var meses = parcela + 1;
		//		var valorTotal = CalcularValorMontanteComJurosCompostos(valorFinanciamento, taxa, meses);
		//		var financiamento = new SimulacaoParcela(meses, valorTotal);

		//		lista.Add(financiamento);
		//	}
		//	return lista;
		//}



		public List<SimulacaoParcela> CalcularSimulacaoDeFinanciamentos(decimal valorFinanciamento, decimal taxa, int parcelas, DateTime database)
		{
			var lista = new List<SimulacaoParcela>();
			var vencimento = database;

			for (int parcela = 0; parcela < parcelas; parcela++)
			{

				var meses = parcela + 1;
				var valorTotal = CalcularValorMontanteComJurosCompostos(valorFinanciamento, taxa, meses);
				var valorParcela = Math.Round(valorTotal / meses, decimals: 2);
				var totalDeJuros = (valorParcela * meses) - valorFinanciamento;

				vencimento = vencimento.AddDays(30);

				var financiamento = new SimulacaoParcela(meses, valorParcela, totalDeJuros, vencimento);

				lista.Add(financiamento);
			}
			return lista;
		}



		public List<SimulacaoParcela> CalcularSimulacaoDeFinanciamentos(decimal valorFinanciamento, decimal taxa, int parcelas)
		{
			
			return CalcularSimulacaoDeFinanciamentos(valorFinanciamento, taxa, parcelas, DateTime.Now.Date);
		}
	}


}
