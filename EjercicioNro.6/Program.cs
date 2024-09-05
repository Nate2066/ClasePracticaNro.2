using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro._6
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
                    Console.WriteLine(" que desea ordenar?");
                    Console.WriteLine(" 1.  arreglo numerico");
                    Console.WriteLine(" 2.  arreglo de palabras o frases");
                    Console.WriteLine(" 3.  Salir");
                    byte opc = Convert.ToByte(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Ingrese el tamano del arreglo");
                            int tamanoArreglo = Convert.ToInt32(Console.ReadLine());

                            int[] arregloNumerico = new int[tamanoArreglo];

                            Console.WriteLine("Ahora ingrese los valores del arreglo");
                            for (int i = 0; i < tamanoArreglo; i++)
                            {
                                arregloNumerico[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.Clear();
                            _Ordenamiento(arregloNumerico);
                            _ImprimirArreglo(arregloNumerico);
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Ingrese el tamano del arreglo");
                            int tamanoArregloAbc = Convert.ToInt32(Console.ReadLine());

                            string[] arregloAbc = new string[tamanoArregloAbc];

                            Console.WriteLine("Ahora ingrese los valores del arreglo");
                            for (int i = 0; i < tamanoArregloAbc; i++)
                            {
                                arregloAbc[i] = Console.ReadLine();
                            }
                            Console.Clear();
                            _Ordenamiento(arregloAbc);
                            _ImprimirArreglo(arregloAbc);
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            salir = true;
                            break;
                        default:
                            _MensajeError();
                            break;
                    }
                }
                catch (FormatException) { _MensajeError(); }
                catch (IndexOutOfRangeException) { _MensajeError(); }
            } while (!salir);
        }

        //metodo de ordenamiento bubble sort
        static void _Ordenamiento(int[] arreglo)
        {
            int arregloTamano = arreglo.Length;
            for (int i = 0; i < arregloTamano; i++)
            {
                for (int j = 0; j < arregloTamano - i - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int tempo = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = tempo;
                    }
                }
            }
        }
        static void _Ordenamiento(string[] arreglo)
        {
            Array.Sort(arreglo);
        }

        static void _ImprimirArreglo(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Posicion: {0} | Valor: {1}", i + 1, arreglo[i]);
            }
        }
        static void _ImprimirArreglo(string[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Posicion: {0} | Valor: {1}", i + 1, arreglo[i]);
            }
        }
        static void _MensajeError()
        {
            Console.Clear();
            Console.WriteLine("Error! intente otra vez");
            Console.ReadKey();
        }
    }
}
