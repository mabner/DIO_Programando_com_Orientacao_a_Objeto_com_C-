using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
	public abstract class Conta
	{
		protected double saldo;

		public abstract void Creditar(double valor);

		public void ExibirSaldo()
		{
			System.Console.WriteLine("Saldo: " + saldo);
		}
	}
}