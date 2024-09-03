using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Que figura desea calacular?\n");
                    Console.WriteLine("1. cuadrado ");
                    Console.WriteLine("2. triangulo equilatero");
                    Console.WriteLine("3. circulo");
                    byte opc = Convert.ToByte(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Ingrese el tamano del lado del cuadrado");
                            double lado = Convert.ToDouble(Console.ReadLine());
                            _CalculoFigurasGeometricas(lado);
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Ingrese el vaor de la base del triangulo");
                            double baseT = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese la altura del triangulo");
                            double altura = Convert.ToDouble(Console.ReadLine());
                            _CalculoFigurasGeometricas(0.5, baseT, altura);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Ingrese el radio del circulo");
                            double radio = Convert.ToDouble(Console.ReadLine());
                            _CalculoFigurasGeometricas(radio, Math.PI);
                            break;
                    }
                }
                catch (FormatException) { _MensajeError(); }
                catch (IndexOutOfRangeException) { _MensajeError(); }
            } while (!salir);
        }
        static void _MensajeError()
        {
            Console.Clear();
            Console.WriteLine("Error! intente otra vez");
            Console.ReadKey();
        }
        static void _CalculoFigurasGeometricas(double pLado)
        {
            Console.Clear();
            Console.WriteLine("El area del cuadrado es de {0}", pLado * pLado);
            Console.ReadKey();
        }
        static void _CalculoFigurasGeometricas(double pDecimal, double pBase, double pAltura)
        {
            Console.Clear();
            double area = pDecimal * pBase * pAltura;
            Console.WriteLine("El area del triangulo es de {0}", area);
            Console.ReadKey();
        }
        static void _CalculoFigurasGeometricas(double pRadio, double PI)
        {
            Console.Clear();
            double area = PI * Math.Pow(pRadio, 2);
            Console.WriteLine("El area del circulo es de {0}", area);
            Console.ReadKey();
        }
    }
}
