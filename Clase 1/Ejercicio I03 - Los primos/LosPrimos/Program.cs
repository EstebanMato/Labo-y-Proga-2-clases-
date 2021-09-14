using System;

namespace LosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string numAux;
            bool esPrimo = true;

            while(true)
            {

                Console.Write("Ingrese un número: ");
                numAux = Console.ReadLine();

                if (int.TryParse(numAux, out num))
                {
                    Console.Write("Los números primos son ");
                    for (int j = 2; j <= num; j++)
                    {
                        esPrimo = true;
                        for (int i = 2; i < j; i++)
                        {
                            if (j % i == 0)
                                esPrimo = false;
                        }
                        if (esPrimo)
                        {
                            Console.Write($" {j} ");
                        }
                    }
                    break;
                }
                else if (numAux == "Salir")
                {
                    Console.WriteLine("Ingreso Salir");
                    break;
                }
                else
                {
                    Console.WriteLine("Número no valido");       
                
                }
            }
        }
    }
}
