using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] producto;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.producto = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion)
            :this(capacidad)
        {
            ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos ()
        {
            return this.producto;
        }

        public static bool operator == (Estante e, Producto p)
        {
            for (int i = 0; i < e.producto.Length; i++)
            {
                if(e.producto[i] == p)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            if(e != p)
            {
                for (int i = 0; i < e.producto.Length; i++)
                {
                    if (e.producto[i] is null)
                    {
                        e.producto[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if(e == p)
            {
                for (int i = 0; i < e.producto.Length; i++)
                {
                    if(e.producto[i] == p)
                    {
                        e.producto[i] = null;
                        break;
                    }

                }
            }
            return e;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ubicacion {e.ubicacionEstante}");

            for (int i = 0; i < e.producto.Length; i++)
            {
                if (!(e.producto[i] is null))
                {
                    sb.AppendLine(Producto.MostrarProducto(e.producto[i]);
                }
            }
            return sb.ToString();
        }

    }
}
