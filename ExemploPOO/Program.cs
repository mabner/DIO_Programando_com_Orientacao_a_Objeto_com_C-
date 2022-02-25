using ExemploPOO.Helper;
using ExemploPOO.Models;

namespace ExemploPOO
{
	class Program
	{
		static void Main(string[] args)
		{
			var caminho = "C:\\Development";

			FileHelper fileHelper = new FileHelper();
			fileHelper.ListarDiretorios(caminho);

			// Calculadora calc = new Calculadora();
			// System.Console.WriteLine(calc.Somar(10, 25));

			// Computador comp = new Computador();
			// System.Console.WriteLine(comp.ToString());

			// Corrente cc = new Corrente();
			// cc.Creditar(100);
			// cc.ExibirSaldo();

			// Calculadora calc1 = new Calculadora();
			// System.Console.WriteLine(calc1.Somar(5, 3));

			// Calculadora calc2 = new Calculadora();
			// System.Console.WriteLine(calc2.Somar(5, 3, 2));

			// Aluno a1 = new Aluno();
			// a1.Nome = "Marcos";
			// a1.Idade = 34;
			// a1.Nota = 10;

			// a1.Apresentar();

			// Professor p1 = new Professor();
			// p1.Nome = "Leidiane";
			// p1.Idade = 34;
			// p1.Salario = 16000;

			// p1.Apresentar();

			// Retangulo ret1 = new Retangulo();
			// ret1.DefinirMedidas(30, 30);
			// System.Console.WriteLine($"Area: {ret1.ObterArea()}");

			// Retangulo ret2 = new Retangulo();
			// ret2.DefinirMedidas(-10, 0);
			// System.Console.WriteLine($"Area: {ret2.ObterArea()}");

			// Pessoa p1 = new Pessoa();

			// p1.Nome = "Marcos";
			// p1.Idade = 34;

			// p1.Apresentar();
		}
	}
}