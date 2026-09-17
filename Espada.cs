using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesClassesAbstratas
{
    internal class Espada : Arma
    {
        public override double CalcularAtaqueCritico()
        {
            return DanoBase * 2;
        }
    }
}