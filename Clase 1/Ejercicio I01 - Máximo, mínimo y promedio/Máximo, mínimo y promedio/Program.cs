using System;

namespace MáximoMínimoPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int suma = 0;
            int num;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                string aux = Console.ReadLine(); 
                int.TryParse(aux, out num);

                if(num<min)
                {
                    min = num;
                }
                if(num>max)
                {
                    max = num;
                }
                suma += num;

            }
            Console.WriteLine($"El número maximo fue {max}, el minimo {min} y la suma {suma}");
        }
    }
}
