using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _ConversionMedidas();
        }
        static void _ConversionMedidas()
        {
            Console.Clear();

            Console.WriteLine("Digite la cantidad de unidades");
            int unidades = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite la medida base");
            string medidaBase = Console.ReadLine();
            Console.WriteLine("Digite la medida nueva");
            string medidaNueva = Console.ReadLine();

            double resultado = Convert.ToDouble(_ConversionProceso(unidades, medidaBase, medidaNueva));

            Console.WriteLine("{0} {1} en {2} son {3} {4}", unidades, medidaBase, medidaNueva, resultado, medidaNueva);
            Console.ReadKey();
        }
        static double _ConversionProceso(int cantidad, string medidaBase, string medidaNueva)
        {
            if (medidaBase == "cm" && medidaNueva == "m")
                return cantidad / 100;
            if (medidaBase == "m" && medidaNueva == "km")
                return cantidad / 1000;
            if (medidaBase == "km" && medidaNueva == "m")
                return cantidad * 1000;
            if (medidaBase == "m" && medidaNueva == "cm")
                return cantidad * 100;

            Console.WriteLine("Medida incorrecta o desconocida, pruebe con: cm, m o km");
            return cantidad;
        }
    }
}
