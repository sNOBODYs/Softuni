using System;

namespace Kонтевиране_от_инчове_в_сантиметри
{
	class Program
	{
		static void Main(string[] args)
		{
			int pokrivki = int.Parse(Console.ReadLine());
			double dlpravMasi = double.Parse(Console.ReadLine());
			double shirPravMasi = double.Parse(Console.ReadLine());
			double cenaPo = dlpravMasi * 7;
			double cenaKa = pokrivki * 9;

			double sumUSD = dlpravMasi * shirPravMasi;
			double sumBGN = sumUSD * 1.85;


			Console.WriteLine($"{sumUSD:f2} USD.");
			Console.WriteLine($"{sumBGN:f2} BGN.");

		}
	}
}
