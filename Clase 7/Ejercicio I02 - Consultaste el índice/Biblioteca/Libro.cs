using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Libro
    {
        private List<string> paginas;

        public string this[int i]
        {
            get
            {
                return this.paginas[i];
            }
            set
            {
                if(paginas.Count<i)
                {
                    paginas.Add(value);
                }
                else
                {
                    this.paginas[i] = value;
                }
            }
        }
    }
}
