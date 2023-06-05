using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Ejercicio3
    {
        public static void Ejercicio()
        {
            int total = 0;
            Console.WriteLine("Ingrese el primer numero:");
            int val1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int val2 = int.Parse(Console.ReadLine());

            int res1 = val1 % 2;
            if (res1 == 0)
            {
                total += res1;
            }
            int res2 = val2 % 2;
            if (res2 == 0)
            {
                total += res2;
            }
            if (res1 == res2)
            {
                Console.WriteLine("Los numeros son amigos");
            }
            else
            {
                Console.WriteLine("Los numeros NO son amigos");
            }
            Console.ReadKey();
        }
    }
}
