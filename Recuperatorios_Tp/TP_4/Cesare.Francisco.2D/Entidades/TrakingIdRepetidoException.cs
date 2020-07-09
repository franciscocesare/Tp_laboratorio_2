using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrakingIdRepetidoException : Exception
    {
        public TrakingIdRepetidoException() : base() { }

        public TrakingIdRepetidoException(string message) : base(message)
        {
        }

        public TrakingIdRepetidoException(string message, Exception inner) : base(message, inner)
        {

        }



    }




}

