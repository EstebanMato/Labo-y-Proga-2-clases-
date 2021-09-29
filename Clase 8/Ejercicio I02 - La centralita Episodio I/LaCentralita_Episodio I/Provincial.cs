using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCentralita_Episodio_I
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }

        public Franja franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }


        public Provincial(Franja miFranja, Llamada llamada)
            :this(llamada.NroOrigen, miFranja ,llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float returnAux = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    {
                        returnAux = this.Duracion * (float)0.99;
                        break;
                    }
                case Franja.Franja_2:
                    {
                        returnAux = this.Duracion * (float)1.25;
                        break;
                    }
                default:
                    {
                        returnAux = this.Duracion * (float)0.66;
                        break;
                    }
            }
            return returnAux;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"El costo de la llamada fue de {this.CostoLlamada} y la franja horaria {this.franjaHoraria.ToString()}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }
    }
}
