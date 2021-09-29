using System;
using System.Text;

namespace LaCentralita_Episodio_I
{
    
    public abstract class Llamada
    {
        public enum TipoLlamada
        {
            Local, Provincial, Todas,
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion
        {
            get
            {
                return duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }

        public abstract float CostoLlamada
        {
            get;
        }

        virtual protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nEl numero de origen es: {this.NroOrigen.ToString()}");
            sb.AppendLine($"El numero de destino es: {this.NroDestino.ToString()}");
            sb.Append($"La duracion de la llamada fue {this.Duracion.ToString()}");

            return sb.ToString();

        }

        public static int OrdernarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if(llamada1.Duracion > llamada2.Duracion)
            {
                return 1;
            }
            else if (llamada1.Duracion < llamada2.Duracion)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        
        public static bool operator != (Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2) && l1.NroOrigen == l2.NroOrigen && l1.NroDestino == l2.NroDestino;
        }

    }
}
