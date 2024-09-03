
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(_Factorial(numero));
        }
        static int _Factorial(int pNumero)
        {
            if (pNumero == 1)
            {
                return 1;
            }
            else
            {
                return pNumero * _Factorial(pNumero - 1);
            }
        }
    }
}
