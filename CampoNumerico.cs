using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesClassesAbstratas
{
    internal class CampoNumerico : CampoFormulario, IValidavel
    {
        public bool Validar()
        {
            return int.TryParse(Valor, out _);
        }
    }
}