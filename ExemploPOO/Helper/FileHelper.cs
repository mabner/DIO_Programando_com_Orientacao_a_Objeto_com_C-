using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Helper
{
	public class FileHelper
	{
		public void ListarDiretorios(string caminho)
		{

			var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

			// prints the directories inside the path
			foreach (var item in retornoCaminho)
			{
				System.Console.WriteLine(item);
			}
		}

		public void ListarArquivosDiretorios(string caminho)
		{

			var retornoArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

			// prints the directories inside the path
			foreach (var item in retornoArquivos)
			{
				System.Console.WriteLine(item);
			}
		}

		public void CriarDiretorio(string caminho)
		{
			var retorno = Directory.CreateDirectory(caminho);
			System.Console.WriteLine(retorno.FullName);
		}

		public void ApagarDiretorio(string caminho, bool apagarArquivos)
		{
			Directory.Delete(caminho, apagarArquivos);
		}

		public void CriarArquivoTexto(string caminho, string conteudo)
		{
			if (!File.Exists(caminho))
			{
				File.WriteAllText(caminho, conteudo);
			}
			else System.Console.WriteLine("Arquivo já existe");
		}

		public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
		{
			using (var stream = File.CreateText(caminho))
			{
				foreach (var linha in conteudo)
				{
					// write on stream, stream writes on file
					stream.WriteLine(linha);
				}
			}
		}

		public void AdicionarTexto(string caminho, string conteudo)
		{
			File.AppendAllText(caminho, conteudo);
		}

		public void AdicionarArquivoTextoStream(string caminho, List<string> conteudo)
		{
			// append text to an existing file
			using (var stream = File.AppendText(caminho))
			{
				foreach (var linha in conteudo)
				{
					// write on stream, stream writes on file
					stream.WriteLine(linha);
				}
			}
		}

		public void LerArquivo(string caminho)
		{
			// conteudo receives an array with all the lines inside the file
			var conteudo = File.ReadAllLines(caminho);

			foreach (var linha in conteudo)
			{
				// print the lines inside the array conteudo
				System.Console.WriteLine(linha);
			}
		}

		// read file using stream
		public void LerArquivoStream(string caminho)
		{
			string linha = string.Empty;

			using (var stream = File.OpenText(caminho))
			{
				while ((linha = stream.ReadLine()) != null)
				{
					System.Console.WriteLine(linha);
				}
			}
		}
	}
}