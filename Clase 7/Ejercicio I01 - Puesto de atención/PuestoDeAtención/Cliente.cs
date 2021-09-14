using System;

namespace PuestoDeAtención
{
    public class Cliente
    {
        string nombre;
        int numero;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public Cliente (int numero)
        {
            this.Numero = numero;
        }

        public Cliente(int numero, string nombre)
            :this(numero)
        {
            this.nombre = nombre;
        }

        public static bool operator != (Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Numero == c2.Numero;
        }
    }

}
