using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class NumeroException : Exception
    {
        public NumeroException() : base()
        {
        }

        public NumeroException(string message) : base(message)
        { }
        public NumeroException(string message, Exception innerExeption) : base(message, innerExeption)
        {

        }
    }
}

