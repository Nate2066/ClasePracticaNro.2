using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce un número de elementos");
        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numero; i++)
        {
            Console.Write("{0} ", _Fibonacci(i));
        }
    }

    static int _Fibonacci(int pNumero)
    {
        if (pNumero <= 1)
        {
            return pNumero;
        }
        else
        {
            return _Fibonacci(pNumero - 1) + _Fibonacci(pNumero - 2);
        }
    }
}