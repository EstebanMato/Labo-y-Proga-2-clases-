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

        public string MostrarEstante(Estante e)
        {

        }

    }
}
