using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Creo que necesito un prestamo";
            Cuenta primeraCuenta;
            primeraCuenta = new Cuenta("Frances" , 100);
            Console.WriteLine(primeraCuenta.Mostrar());
            primeraCuenta.Retirar(150);
            Console.WriteLine(primeraCuenta.Mostrar());
            primeraCuenta.Ingresar(123.456);
            Console.WriteLine(primeraCuenta.Mostrar());

        }
    }
}
