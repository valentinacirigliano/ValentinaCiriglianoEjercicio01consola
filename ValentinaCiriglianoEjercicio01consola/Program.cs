using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValentinaCiriglianoEjercicio01consola
{
    class Program
    {
        static void Main(string[] args)
        {
            double catetoA, catetoB;
            double hipotenusaValorFinal, perimetro, superficie, hipotenusaPaso1;

            Console.Write("Ingrese el valor del primer cateto:  ");
            catetoA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el valor del segundo cateto:  ");
            catetoB = Convert.ToDouble(Console.ReadLine());

            superficie = (catetoA * catetoB) / 2;
            hipotenusaPaso1 = ((catetoA * catetoA) + (catetoB * catetoB));
            hipotenusaValorFinal = Math.Sqrt(hipotenusaPaso1);
            perimetro = catetoA + catetoB + hipotenusaValorFinal;

            Console.Clear();
            Console.WriteLine("RESULTADOS");
            Console.WriteLine(" ");
            Console.WriteLine($"La superficie del triángulo es de {superficie} cm.");
            Console.WriteLine($"El perímetro del triángulo es de {perimetro} cm.");
            Console.ReadLine();

        }
    }
}
