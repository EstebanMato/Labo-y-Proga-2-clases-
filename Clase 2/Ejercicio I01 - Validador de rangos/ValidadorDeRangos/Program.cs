using System;
using Biblioteca;

namespace ValidadorDeRangos
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int min = int.MaxValue;
            int max = int.MinValue;
            float contador = 0;
            float acumulador = 0;

            while(contador<3)
            { 
                Console.WriteLine("Ingrese un numero");
                if(int.TryParse(Console.ReadLine(), out valor))
                {
                    if(Validador.Validar(valor,-100,100))
                    {
                        contador++;
                        if (valor > max)
                            max = valor;
                        if (valor < min)
                            min = valor;
                        acumulador += valor;
                    }
                    else
                    {
                        Console.WriteLine("Numero fuera de rango");
                    }
                }
                else
                {
                    Console.WriteLine("No es un numero");
                }
            } 

            Console.WriteLine($"El valor maximo es {max} y el valor minimo {min}");
            Console.WriteLine($"El promedio es {acumulador/contador}");
        }
    }
}
