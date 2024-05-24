using ConsoleAppCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharp
{
	internal class Program
	{
		static void Main(string[] args)
		{



			var memos_ids = new string[] { "txtVocabularyMyLanguage", "txtTranslation", "txtTip", "txtVocLanguageLearning", "txtWordOrPhrase", "txtSimplified" };

			foreach (string memo in memos_ids)
			{
				Console.WriteLine(memo);
			}






			//var calculadora = new Calculadora();


			//Console.WriteLine("\nVamos simular um Financiamento que cobra juros compostos?");
			//Console.WriteLine("\nMe informe o valor do financiamento: ");

			//var valorFinanciamento = Convert.ToDecimal(Console.ReadLine());

			//Console.WriteLine("\nAgora me informe o valor da taxa: ");

			//var taxa = Convert.ToDecimal(Console.ReadLine());

			//Console.WriteLine("\nQuantas parcelas pode ter o financiamento?: ");

			//var parcelas = Convert.ToInt32(Console.ReadLine());

			//var simulacao = calculadora.CalcularSimulacaoDeFinanciamentos(valorFinanciamento, taxa, parcelas);

			//Console.WriteLine($"\nVoce quer parcelar {valorFinanciamento}R$ sobre uma taxa de {taxa}% em até {parcelas} parcelas.");
			//Console.WriteLine($"\nEstas são as opções de parcelamento: \n");


			//for (int item = 0; item < simulacao.Count; item++)
			//{
			//	int num_parcela = simulacao[item].Quantidade;
			//	decimal valor = simulacao[item].ValorTotal;
			//	DateTime vencimento = simulacao[item].Vencimento;


			//	Console.WriteLine($"\tParcelar em \t{num_parcela} x {Math.Round(valor/num_parcela, decimals: 2)}R$, \tque totaliza em \t{valor}R$ - (juros: {valor-valorFinanciamento}) - com ultimo vencimento em {vencimento.ToString("dd/MM/yyyy")}");


			//}

			//Console.WriteLine($"\n");


		}
	}
}












//Console.WriteLine("Informe um número: ");

//var texto = Console.ReadLine();

//if (int.TryParse(texto, out int numero))
//{

//	var par = calcular.EhPar(numero);

//	if (par)
//	{
//		Console.WriteLine("Numero par");
//	}
//	else
//	{
//		Console.WriteLine("Numero impar");

//	}

//}
//else
//{
//	Console.WriteLine("That is not a number my son");
//}



//Console.WriteLine("Escreva o valor da parcela: ");

//var parcela = Convert.ToDecimal(Console.ReadLine());


//Console.WriteLine("Escreva a taxa: ");

//var taxa = Convert.ToDecimal(Console.ReadLine());

//decimal total = calcular.CalcularTotalJurosSimples(parcela, taxa);

//Console.WriteLine($"o juros é: {total} R$");


//Console.WriteLine("Vamos calcular juros compostos");
//Console.WriteLine("Me informe o valor da parcela: ");

//var parcela = Convert.ToDecimal(Console.ReadLine());

//Console.WriteLine("Agora me informe o valor da taxa: ");

//var taxa = Convert.ToDecimal(Console.ReadLine());

//Console.WriteLine("Durante quantos meses: ");

//var meses = Convert.ToInt32(Console.ReadLine());

//var montante = calculadora.CalcularValorMontanteComJurosCompostos(parcela, taxa, meses);

//Console.WriteLine($"este será o seu montante depois de {meses} meses, com uma taxa de {taxa}% sobre {parcela}R$: {montante}");

