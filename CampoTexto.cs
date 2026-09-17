using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesClassesAbstratas
{
    internal class CampoTexto : CampoFormulario, IValidavel
    {
        public bool Validar()
        {
            return !string.IsNullOrEmpty(Valor);
        }
    }
}