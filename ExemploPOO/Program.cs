using ExemploPOO.Helper;
using ExemploPOO.Models;

namespace ExemploPOO
{
	class Program
	{
		static void Main(string[] args)
		{
			var caminho = "/run/media/topgear/My Passport/@Backup_18_01_2022/dev/repo/cursos/DIO/Programando com Orientação a Objeto com C#/";
			var caminhoPathCombine = Path.Combine(caminho, "Pasta 2");
			var caminhoArquivo = Path.Combine(caminho, "Peixes.txt");

			var listaString = new List<string> { "Pseudochromis Fridmani", "Ocelaris", "Kupang", "Yellow Coris" };
			var listaStringAppend = new List<string> { "Anemona BBT Rainbow", "Duncan Coral" };

			FileHelper fileHelper = new FileHelper();

			// fileHelper.ListarDiretorios(caminho);
			// fileHelper.ListarArquivosDiretorios(caminho);

			// System.Console.WriteLine("Caminho: " + caminhoPathCombine);
			// fileHelper.CriarDiretorio(caminhoPathCombine);

			// fileHelper.ApagarDiretorio(caminhoPathCombine, true);

			// fileHelper.CriarArquivoTexto(caminhoArquivo, "Teste de escrita em arquivo.\nArquivo de texto criado por código");

			// Creates the file
			// fileHelper.CriarArquivoTextoStream(caminhoArquivo, listaString);
			// Append aditional text to it
			// fileHelper.AdicionarArquivoTextoStream(caminhoArquivo, listaStringAppend);

			fileHelper.LerArquivoStream(caminhoArquivo);

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