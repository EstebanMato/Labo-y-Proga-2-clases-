using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmPrincipal
{
    public class ParametrosVaciosException : Exception

    {
        public ParametrosVaciosException(string message, Exception inner)
            : base(message, inner)
        {
               
        }
        public ParametrosVaciosException(string message)
            :this(message, null)
            
        {

        }

    }
}
