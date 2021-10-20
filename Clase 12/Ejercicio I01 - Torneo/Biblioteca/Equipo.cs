using System;

namespace Biblioteca
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;
        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }

        public static bool operator == (Equipo equipo1, Equipo equipo2)
        {
            return equipo1.nombre == equipo2.nombre && equipo1.fechaCreacion == equipo2.fechaCreacion;
        }

        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }

        public string Ficha()
        {
            return $"{this.nombre} fundado el {fechaCreacion.ToString("dd/MM/YYYY")}";
        }
    }
}
