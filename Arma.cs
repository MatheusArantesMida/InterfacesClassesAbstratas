using System;

namespace InterfacesClassesAbstratas
{
    abstract class Arma
    {
        public string Nome { get; set; } = "";
        public double DanoBase { get; set; }
        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome} | Dano base: {DanoBase}");
        }
        public abstract double CalcularAtaqueCritico();
    }
}