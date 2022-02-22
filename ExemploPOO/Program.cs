using ExemploPOO.Models;

namespace ExemploPOO
{
	class Program
	{
		static void Main(string[] args)
		{
			Retangulo ret = new Retangulo();
			ret.DefinirMedidas(30, 30);

			System.Console.WriteLine($"Area: (ret.ObterArea())");

			// Pessoa p1 = new Pessoa();

			// p1.Nome = "Marcos";
			// p1.Idade = 34;

			// p1.Apresentar();
		}
	}
}