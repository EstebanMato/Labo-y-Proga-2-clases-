using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElViajarEsUnPlacer
{
    public class Moto : VehiculoTerrestre
    {
        short cantidadRuedas;
        short CantidadPuertas;
        Colores color;
        short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;
        }
    }
}
