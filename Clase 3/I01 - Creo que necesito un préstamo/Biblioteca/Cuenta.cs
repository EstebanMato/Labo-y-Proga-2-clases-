using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return titular;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titular: {this.GetTitular()}");
            sb.AppendLine($"El monto actual es {this.GetCantidad()}");

            return sb.ToString();
        }
        public void Ingresar(double monto)
        {
            if(monto>= 0)
            {
                this.cantidad += monto;
            }
        }

        public void Retirar(float monto)
        {
            if (monto >= 0)
            {
                this.cantidad -= monto;
            }
        }
    }
}
