using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prácticar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el costo del producto C: ");
            double costoC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese su tiempo de vida útil N: ");
            int tiempoN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el mes en números ( 1 al 12): ");
            int mes = Convert.ToInt32(Console.ReadLine());

            double depreciacion = TotalDeprec(costoC, tiempoN, mes);
            String calificacion = CalificarDeprec(depreciacion);

            Console.WriteLine("La depreciación del mes " + mes +" s/ "+ depreciacion.ToString("0.00"));
            Console.WriteLine("Su calificación es "+calificacion);
            Console.ReadKey();
        }
        static double TotalDeprec(double costoC, int tiempoN, int mes)
        {
            double depreciacion = costoC * (1 - (1.0 / tiempoN) * mes);
            return depreciacion;
        }
        static string CalificarDeprec(double depreciacion)
        {
            if (depreciacion < 500)
            { return "A"; }
            else if (depreciacion < 750)
            { return "B"; }
            else if (depreciacion > 750)
            { return "C"; }
            else
            { return "error"; }
   
        }
    }
}
