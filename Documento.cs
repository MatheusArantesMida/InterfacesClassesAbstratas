using System;

namespace InterfacesClassesAbstratas
{
    internal class Documento : ISalvavel
    {
        public void Salvar()
        {
            Console.WriteLine("Salvando o documento em formato .DOC");
        }
    }
}