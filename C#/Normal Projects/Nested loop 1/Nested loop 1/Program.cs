using System;

namespace Nested_loop_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string num = n.ToString();

			for (int i = 0; i < num.Length; i++)
			{
				int number = n % 10;
				int lastDigit = n / 10;
				n = lastDigit;

				if (number == 0)
				{
					Console.Write("ZERO");
				}
				for (int z = 0; z < number; z++)
				{
					int znak = number + 33;
					char simvol = (char)znak;
					Console.Write(simvol);
				}
				Console.WriteLine();
			}
		}
	}
}