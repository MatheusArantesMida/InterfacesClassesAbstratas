using System;

namespace InterfacesClassesAbstratas
{
    internal class Foto : ISalvavel
    {
        public void Salvar()
        {
            Console.WriteLine("Salvando a foto em formato .JPG");
        }
    }
}