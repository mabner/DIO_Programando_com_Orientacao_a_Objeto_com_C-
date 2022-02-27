using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
	public interface ICalculadora
	{
		int Somar(int num1, int num2);
		int Subtrair(int num1, int num2);
		int Multiplicar(int num1, int num2);

		// Implementing the method with parameters in the interface
		// meaning that we do not need to implement the method in the class
		int Dividir(int num1, int num2)
		{
			return num1 / num2;
		}
	}
}