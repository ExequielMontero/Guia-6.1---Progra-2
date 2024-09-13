using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public interface IAnalizador
    {
        string Analizador(string texto, out string patente);

    }
}
