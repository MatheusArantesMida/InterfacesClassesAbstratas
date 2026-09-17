using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesClassesAbstratas
{
    internal class Arco : Arma
    {
        public override double CalcularAtaqueCritico()
        {
            return DanoBase * 3;
        }
    }
}