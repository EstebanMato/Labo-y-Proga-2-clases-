using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCentralita_Episodio_I
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            :this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;

            if(this.Llamadas is not null)
            {
                foreach (Llamada llamada in this.Llamadas)
                {
                    if(llamada is Local)
                    {
                        gananciaLocal += ((Local)llamada).CostoLlamada;
                    }
                    if(llamada is Provincial)
                    {
                        gananciaProvincial += ((Provincial)llamada).CostoLlamada;
                    } 
                }
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        return gananciaLocal;

                    case Llamada.TipoLlamada.Provincial:
                        return gananciaProvincial;

                    default:
                        return gananciaLocal + gananciaProvincial;
                }
            }
            return 0;
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if(nuevaLlamada is not null)
            {
                this.listaDeLlamadas.Add(nuevaLlamada);
            }
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razón social: {this.razonSocial}");
            sb.AppendLine($"La ganancia total es: {this.CalcularGanancia(Llamada.TipoLlamada.Todas)}");
            sb.AppendLine($"La ganancia local es: {this.CalcularGanancia(Llamada.TipoLlamada.Local)}");
            sb.AppendLine($"La ganancia provincial es: {this.CalcularGanancia(Llamada.TipoLlamada.Provincial)}");

            foreach (Llamada llamada in this.Llamadas)
            {
                sb.AppendLine(llamada.ToString());
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdernarPorDuracion);
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator + (Centralita c, Llamada nuevaLlamada)
        {
            if(c!= nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }
            return c;
        }

        public static bool operator == (Centralita c, Llamada llamada)
        {
            foreach(Llamada item in c.listaDeLlamadas)
            {
                if (item == llamada)
                    return true;
            }
            return false;
        }

    }
}
