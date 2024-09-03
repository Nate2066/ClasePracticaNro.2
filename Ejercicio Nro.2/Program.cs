using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            _TablaDeMultiplicar(numero, 12);
        }
        static int _TablaDeMultiplicar(int pNumero, int pMultiplicacion)
        {
            if(pMultiplicacion == 0)
            {
                return 1;
            }
            else
            {
                int multiplicacion = _TablaDeMultiplicar(pNumero, pMultiplicacion - 1);
                Console.WriteLine("{0} x {1} = {2}", pNumero, multiplicacion, pNumero * multiplicacion);
                return pMultiplicacion + 1;
            }
        }
    }
}
