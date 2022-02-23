using ExemploPOO.Models;

namespace ExemploPOO
{
	class Program
	{
		static void Main(string[] args)
		{
			Retangulo ret1 = new Retangulo();
			ret1.DefinirMedidas(30, 30);
			System.Console.WriteLine($"Area: {ret1.ObterArea()}");

			Retangulo ret2 = new Retangulo();
			ret2.DefinirMedidas(-10, 0);
			System.Console.WriteLine($"Area: {ret2.ObterArea()}");

			// Pessoa p1 = new Pessoa();

			// p1.Nome = "Marcos";
			// p1.Idade = 34;

			// p1.Apresentar();
		}
	}
}