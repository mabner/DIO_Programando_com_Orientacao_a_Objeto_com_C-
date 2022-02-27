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
	}
}