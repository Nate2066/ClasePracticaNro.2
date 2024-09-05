using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractico_04_09_2024
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
                    Console.WriteLine("[0]\n   Seleccione una opcion\n");
                    Console.WriteLine("1. Convertir temperatura");
                    Console.WriteLine("2. Convertir distancia");
                    Console.WriteLine("3. Convertir tiempo\n");
                    Console.WriteLine("0. Salir");
                    byte opc = Convert.ToByte(Console.ReadLine());
                    switch (opc)
                    {
                        case 0:
                            Console.Clear();
                            salir = true;
                            break;
                        case 1:
                            bool regresar = false;
                            do
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("[1]\n   -Convetor temperatura-\n");
                                    Console.WriteLine("1. Convertir Fahrenheit a Celsius");
                                    Console.WriteLine("2. Convertir Celsius a Kelvins");
                                    Console.WriteLine("3. Convertir Celsius a Fahrenheit\n");
                                    Console.WriteLine("0. regresar");
                                    byte opc2 = Convert.ToByte(Console.ReadLine());

                                    switch (opc2)
                                    {
                                        case 0:
                                            regresar = true;
                                            break;
                                        case 1:
                                            Console.Clear();
                                            Console.WriteLine("Ingrese el valor en grados Fahrenheit");
                                            double fahrenheit = Convert.ToDouble(Console.ReadLine());
                                            _ConvertorTemperatura(fahrenheit, opc2);
                                            break;
                                        case 2:
                                            Console.Clear();
                                            Console.WriteLine("Ingrese el valor en grados Celsius");
                                            double celsius = Convert.ToDouble(Console.ReadLine());
                                            _ConvertorTemperatura(celsius, opc2);
                                            break;
                                        case 3:
                                            Console.Clear();
                                            Console.WriteLine("Ingrese el valor en grados Celsius");
                                            celsius = Convert.ToDouble(Console.ReadLine());
                                            _ConvertorTemperatura(celsius, opc2);
                                            break;
                                        default:
                                            _MensajeError("Error!");
                                            break;
                                    }
                                }
                                catch (FormatException) { _MensajeError("Error! ingrese un valor valido"); }
                                catch (IndexOutOfRangeException) { _MensajeError("Error! ingrese un valor valido"); }
                            } while (!regresar);
                            break;
                        case 2:
                            regresar = false;
                            do
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("[2]\n   -Convetor distancia-\n");
                                    Console.WriteLine("1. Convertir Kilometros a Metros");
                                    Console.WriteLine("2. Convertir Metros a Kilometros");
                                    Console.WriteLine("3. Convertir Metros a Centimetros\n");
                                    Console.WriteLine("0. regresar");
                                    byte opc2 = Convert.ToByte(Console.ReadLine());

                                    switch (opc2)
                                    {
                                        case 0:
                                            regresar = true;
                                            break;
                                        case 1:
                                            Console.Clear();
                                            Console.WriteLine("Ingrese el valor en Kilometros");
                                            double kilometros = Convert.ToDouble(Console.ReadLine());
                                            _ConvertorDistancia(kilometros, opc2);
                                            break;
                                        case 2:
                                            Console.Clear();
                                            Console.WriteLine("Ingrese el valor en metros");
                                            double metros = Convert.ToDouble(Console.ReadLine());
                                            _ConvertorDistancia(metros, opc2);
                                            break;
                                        case 3:
                                            Console.Clear();
                                            Console.WriteLine("Ingrese el valor en metros");
                                            metros = Convert.ToDouble(Console.ReadLine());
                                            _ConvertorDistancia(metros, opc2);
                                            break;
                                        default:
                                            _MensajeError("Error!");
                                            break;
                                    }
                                }
                                catch (FormatException) { _MensajeError("Error! ingrese un valor valido"); }
                                catch (IndexOutOfRangeException) { _MensajeError("Error! ingrese un valor valido"); }
                            } while (!regresar);
                            break;
                        case 3:
                            regresar = false;
                            do
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("[3]\n   -Convetor tiempo-\n");
                                    Console.WriteLine("1. Convertir Horas a Minutos");
                                    Console.WriteLine("2. Convertir Minutos a Horas");
                                    Console.WriteLine("3. Convertir Minutos a Segundos\n");
                                    Console.WriteLine("0. regresar");
                                    byte opc2 = Convert.ToByte(Console.ReadLine());

                                    switch (opc2)
                                    {
                                        case 0:
                                            regresar = true;
                                            break;
                                        case 1:
                                            Console.Clear();
                                            Console.WriteLine("Ingrese el valor en Horas");
                                            double horas = Convert.ToDouble(Console.ReadLine());
                                            _ConvertorTiempo(horas, opc2);
                                            break;
                                        case 2:
                                            Console.Clear();
                                            Console.WriteLine("Ingrese el valor en Minutos");
                                            double minutos = Convert.ToDouble(Console.ReadLine());
                                            _ConvertorTiempo(minutos, opc2);
                                            break;
                                        case 3:
                                            Console.Clear();
                                            Console.WriteLine("Ingrese el valor en Minutos");
                                            minutos = Convert.ToDouble(Console.ReadLine());
                                            _ConvertorTiempo(minutos, opc2);
                                            break;
                                        default:
                                            _MensajeError("Error!");
                                            break;
                                    }
                                }
                                catch (FormatException) { _MensajeError("Error! ingrese un valor valido"); }
                                catch (IndexOutOfRangeException) { _MensajeError("Error! ingrese un valor valido"); }
                            } while (!regresar);
                            break;
                    }
                }
                catch (FormatException) { _MensajeError("Error! ingrese un valor valido"); }
                catch (IndexOutOfRangeException) { _MensajeError("Error! ingrese un valor valido"); }
            } while (!salir);
        }
        static void _ConvertorDistancia(double pDistancia, byte pOpcion)
        {
            if (pOpcion == 1)
            {
                double respuesta = pDistancia * 1000;
                Console.WriteLine("{0} Km equivalen a {1} Metros", pDistancia, respuesta);
                Console.ReadKey();
            }
            else if (pOpcion == 2)
            {
                double respuesta = pDistancia / 1000;
                Console.WriteLine("{0} Metros equivalen a {1} Km", pDistancia, respuesta);
                Console.ReadKey();
            }
            else if (pOpcion == 3)
            {
                double respuesta = pDistancia * 100;
                Console.WriteLine("{0} Metros equivalen a {1} Centimetros", pDistancia, respuesta);
                Console.ReadKey();
            }
        }
        static void _ConvertorTemperatura(double pGrados, byte pOpcion)
        {
            if (pOpcion == 1)
            {
                double respuesta = (pGrados - 32) * 5 / 9;
                Console.WriteLine("{0} Grados Fahremheit equivalen a {1} Grados Celsius", pGrados, respuesta);
                Console.ReadKey();
            }
            else if (pOpcion == 2)
            {
                double respuesta = pGrados + 273.15;
                Console.WriteLine("{0} Grados Celsius equivalen a {1} Grados kelvins", pGrados, respuesta);
                Console.ReadKey();
            }
            else if (pOpcion == 3)
            {
                double respuesta = (pGrados * 9 / 5) + 32;
                Console.WriteLine("{0} Grados Celsius equivalen a {1} Grados Fahrenheit", pGrados, respuesta);
                Console.ReadKey();
            }
        }
        static void _ConvertorTiempo(double pTiempo, byte pOpcion)
        {
            if (pOpcion == 1)
            {
                double respuesta = pTiempo * 60;
                Console.WriteLine("{0} Horas equivalen a {1} Minutos", pTiempo, respuesta);
                Console.ReadKey();
            }
            else if (pOpcion == 2)
            {
                double respuesta = pTiempo / 60;
                Console.WriteLine("{0} Minutos equivalen a {1} Horas", pTiempo, respuesta);
                Console.ReadKey();
            }
            else if (pOpcion == 3)
            {
                double respuesta = pTiempo * 60;
                Console.WriteLine("{0} Minutos equivalen a {1} Segundos", pTiempo, respuesta);
                Console.ReadKey();
            }
        }
        static void _MensajeError(string pMensajeError)
        {
            Console.Clear();
            Console.WriteLine(pMensajeError);
            Console.ReadLine();
        }
    }
}
