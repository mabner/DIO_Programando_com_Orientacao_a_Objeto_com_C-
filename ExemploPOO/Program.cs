using ExemploPOO.Models;

namespace ExemploPOO
{
	class Program
	{
		static void Main(string[] args)
		{
			Pessoa p1 = new Pessoa();

			p1.Nome = "Marcos";
			p1.Idade = 34;

			p1.Apresentar();
		}
	}
}