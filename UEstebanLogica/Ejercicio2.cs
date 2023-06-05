using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
	public class Ejercicio2
	{
		public static void Ejercicio()
		{
			Console.WriteLine("Ingresa un número ");
			int numero = int.Parse(Console.ReadLine());


			if (numero >= 0)
			{
				int a = 0;
				int b = 1;
				while (b <= numero)
				{
					Console.Write(b + " ");
					int total = a;
					a = b;
					b = total + b;
				}
			}
			else
			{
				Console.WriteLine("No es un numero");
			}
		}
	}
}
