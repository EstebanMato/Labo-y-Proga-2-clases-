using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PuestoDeAtención
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2
        }
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                PuestoAtencion.numeroActual++;
                return numeroActual;
            }
        }
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion (Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            if((cli is not null) && cli.Numero>=0)
            {
                Thread.Sleep(2000);
                return true;
            }
            return false;
        }

    }
}
