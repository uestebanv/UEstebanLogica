using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
	public class Ejercicio1
	{
		public static void Ejercicio
			()
		{
			Console.WriteLine("Ingresa un número: ");
			int numero = int.Parse(Console.ReadLine());
			int suma = 0;


			for (int i = 1; i < numero; i++)
			{
				if (numero % i == 0)
				{
					suma += i;
				}
			}

			if (suma == numero)
			{
				Console.WriteLine("Es un número perfecto");
			}
			else
			{
				Console.WriteLine("No es un número perfecto");
			}
		}
	}
}
