using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro._7
{
    internal class Program
    {

        static void Main(string[] args)
        {
            CambiarFormato();
        }
        static void CambiarFormato()
        {
            Console.WriteLine("Ingrese el dia");
            byte dd = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingrese el mes");
            byte mm = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingrese el año");
            int aaaa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Elija el formato: 1. dd/mm/aaaa 2. mm/dd/aaaa");
            byte opc = Convert.ToByte(Console.ReadLine());
            if (opc == 1)
            {
                FormatoNuevo(dd, mm, aaaa);
            }
            else if (opc == 2)
            {
                FormatoNuevo(aaaa, mm, dd);
            }
        }
        static void FormatoNuevo(byte dd, byte mm, int aaaa)
        {
            Console.WriteLine("Nuevo formato : {0} / {1} / {2}", dd, mm, aaaa);
        }
        static void FormatoNuevo(int aaaa, byte mm, byte dd)
        {
            Console.WriteLine("Nuevo formato : {0} / {1} / {2}", mm, dd, aaaa);
        }
    }
}
