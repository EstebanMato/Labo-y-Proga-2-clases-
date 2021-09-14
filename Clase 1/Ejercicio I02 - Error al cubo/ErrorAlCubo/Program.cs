using System;

namespace ErrorAlCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string aux;
                int num;

                Console.WriteLine("Ingrese un número");
                aux = Console.ReadLine();
                int.TryParse(aux, out num);

                if (num>0)
                {
                    Console.WriteLine($"El cuadrado de {num}, es {Math.Pow(num, 2)} y el cubo es {Math.Pow(num, 3)}");
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            }
        }
    }
}
