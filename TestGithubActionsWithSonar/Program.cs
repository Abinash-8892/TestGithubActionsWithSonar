using System;

namespace TestGithubActionsWithSonar
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			var t = new TestCalculator();
			Console.WriteLine($"{t.Add(3,5)}");
			Console.WriteLine($"{t.Sub(1, 1)}");
		}
	}
}
