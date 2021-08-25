using System;

namespace Biblioteca
{
    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            return valor <= max && valor >= min;
        }
    }
}
