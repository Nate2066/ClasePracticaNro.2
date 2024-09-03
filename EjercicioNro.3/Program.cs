using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cantidad de elementos");
            int elementos = Convert.ToInt32(Console.ReadLine());
            _SerieFibonacci(elementos);
        }
        static int _SerieFibonacci(int pRango)
        {
            if(pRango == 1)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(_SerieFibonacci(pRango -1) + _SerieFibonacci(pRango -1));
                return pRango + 1;
            }
        }
    }
}
