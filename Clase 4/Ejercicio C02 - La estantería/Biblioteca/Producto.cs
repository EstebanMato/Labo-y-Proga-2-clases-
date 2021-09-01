using System;
using System.Text;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return marca;
        }
        public float GetPrecio()
        {
            return precio;
        }
        public static string MostrarProducto(Producto p )
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de barras :{p.codigoDeBarra} , \n Marca: {p.GetMarca()} \n Precio: {p.GetPrecio()}");

            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
            
        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.codigoDeBarra == p2.codigoDeBarra && p1.GetMarca() == p2.GetMarca();
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p1, String marca)
        {
            return p1.GetMarca() == marca;
        }
        public static bool operator !=(Producto p1, String marca)
        {
            return !(p1 == marca);
        }

    }
}
