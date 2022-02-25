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

	}
}