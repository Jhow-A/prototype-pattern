using System;

namespace PrototypeShallowCopy.ConcretePrototype
{
    public class Soldado : ICloneable
    {
        public string Nome { get; set; }
        public string Arma { get; set; }
        public Acessorio Acessorio { get; set; }

        public Soldado() { }

        public Soldado(Soldado soldado)
        {
            Nome = soldado.Nome;
            Arma = soldado.Arma;
            Acessorio = soldado.Acessorio;
        }

        public object Clone() => new Soldado(this);

        public override string ToString() => $"\t {Nome} - {Arma} \n \t {Acessorio.Nome} \n";
    }
}
