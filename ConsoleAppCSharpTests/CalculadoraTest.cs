using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleAppCSharp;
using FluentAssertions;


namespace ConsoleAppCSharpTests
{
	[TestClass]
	public class CalculadoraTest
	{
		[TestMethod]
		public void AoVerificarSeUmNumeroEhParDeveRetornarVerdadeiro()
		{

			// causa/cenario deve efeito/resultado
			var calculadora = new Calculadora();
			var par = calculadora.EhPar(2);

			if (par == false)
			{
				throw new Exception("Numero dois é par");
			}
		}


		[TestMethod]
		public void AoVerificarSeUmNumeroEhImparDeveRetornarFalso()
		{

			// causa/cenario deve efeito/resultado
			var calculadora = new Calculadora();
			var impar = (calculadora.EhPar(3) == false);

			if (impar == false)
			{
				throw new Exception("Numero tres é impar");
			}
		}



		[TestMethod]
		public void AoCalcularJurosSimplesDeUmaParcelaDeveInformarValorCorreto()
		{
			// AAA

			// arrange
			var parcela = 562.3M;
			var taxa = 2.5M;
			var calculadora = new Calculadora();

			//act
			var totalDoJuros = calculadora.CalcularTotalJurosSimples(parcela, taxa);

			//asser
			if (totalDoJuros != 14.0575M)
			{
				throw new Exception("iiiiiiiiiiiiiiii deu erro");
			}

		}

		[TestMethod]
		public void AoCalcularOMaximoDivisorComumDeVariosNumerosDeveEncontrarOResultadoCorreto()
		{
			var numeros = new int[] { 21, 54, 69, 15, 27, 18 };
			var calculadora = new Calculadora();

			var mdc = calculadora.CalcularMaximoDivisorComum(numeros);

			if (mdc != 3)
			{
				throw new Exception("O MDC dos numeros [ 21, 54, 69, 15, 27, 18 ] deve ser 3, porem, foi encontrado " + mdc.ToString());
			}

			numeros = new int[] { 15, 15, 15, 30, 45, 60 };
			mdc = calculadora.CalcularMaximoDivisorComum(numeros);

			if (mdc != 15)
			{
				throw new Exception(" O MDC de 15, 15, 15, 30, 45, 60 deve ser 15, porem foi " + mdc.ToString());
			}

		}

		[TestMethod]
		public void AoCalcularJurosCompostosDeUmaParcelaDeveRetornarValorCorreto()
		{
			var calculadora = new Calculadora();
			var parcela = 562.3M;
			var taxa = 1.5M;
			var meses = 3;

			var montante = calculadora.CalcularValorMontanteComJurosCompostos(parcela, taxa, meses);

			if (montante != 587.98M) 
			{
				throw new Exception("O valor da parcela não foi calculado corretamente: " + montante.ToString());


			}
		}

		[TestMethod]
		public void SeRealizarUmaSimulacaoDeParcelamentoDeveEncontrarOsValoresCorrretos()
		{
			//arrange
			var calculadora = new Calculadora();
			var valorFinanciamnto = 562.3M;
			var taxa = 1.5M;
			var parcelas = 3;


			//act
			var dataBase = new DateTime(day: 21, month: 5, year: 2024);
			var simulacao = calculadora.CalcularSimulacaoDeFinanciamentos(valorFinanciamnto, taxa, parcelas, dataBase);


			//assert

			simulacao.Count.Should().Be(3, because: "numero de parcelas errado");

			//if (simulacao.Count != 3)
			//	throw new Exception("quantideade de parcelas erradas");

			var primeiroVencimento = new DateTime(2024, 6, 20);
			var segundoVencimento = new DateTime(2024, 7, 20);
			var terceiroVencimento = new DateTime(2024, 8, 19);


			var valoresEsperados = new decimal[] { 570.73M, 579.3M, 587.97M};
			var vencimentosEsperados = new DateTime[]{ primeiroVencimento, segundoVencimento, terceiroVencimento};



			for (int parcela = 1; parcela <= 3; parcela++) 
			{

				simulacao[parcela-1].Quantidade
					.Should()
					.Be(parcela);

				//if (simulacao[parcela - 1].Quantidade != parcela)
				//	throw new Exception("A quantidade de parcelas da parcela [" + parcela.ToString() + "] está errada!");


				simulacao[parcela-1].ValorTotal
					.Should()
					.Be(valoresEsperados[parcela - 1]);

				//if (simulacao[parcela - 1].ValorTotal != valoresEsperados[parcela - 1])
				//	throw new Exception("O valor da parcela [" + parcela.ToString() + "] está errado" + $"Esperavamos {valoresEsperados[parcela - 1]}, porém, está calculando {simulacao[parcela -1].ValorTotal}");


				simulacao[parcela-1].Vencimento
					.Should()
					.Be(vencimentosEsperados[parcela-1]);

				//if (simulacao[parcela-1].Vencimento != vencimentosEsperados[parcela-1])
				//	throw new Exception($"errou, o vencimento da parcela {parcela} esta errado, esperava: {vencimentosEsperados[parcela-1]} mas esta vindo {simulacao[parcela-1].Vencimento}");
					
			}




		}


	}
}
