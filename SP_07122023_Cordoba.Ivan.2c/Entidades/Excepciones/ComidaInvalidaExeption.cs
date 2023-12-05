using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ComidaInvalidaExeption : Exception
    {
        public ComidaInvalidaExeption(string message) : base(message)
        {
        }
    }
}
