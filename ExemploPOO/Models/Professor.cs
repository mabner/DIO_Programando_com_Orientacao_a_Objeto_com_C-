using ExemploPOO.Models;

namespace ExemploPOO
{
	public class Professor : Pessoa
	{
		public double Salario {get; set;}

		// Polimorfismo em tempo de execução
		public override void Apresentar()
		{
			Console.WriteLine($"Olá, meu nome é {Nome} e sou professor. Meu salário é {Salario}.");
		}
	}
}