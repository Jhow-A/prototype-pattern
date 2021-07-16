using System;

namespace PrototypeDeepCopy.ConcretePrototype
{
    public class Soldado : ICloneable
    {
        public string Nome { get; set; }
        public string Arma { get; set; }
        public Acessorio Acessorio { get; set; }

        public object Clone()
        {
            var soldado = this.MemberwiseClone() as Soldado;
            soldado.Acessorio = Acessorio.Clone() as Acessorio;

            return soldado;
        }

        public override string ToString() => $"\t {Nome} - {Arma} \n \t {Acessorio.Nome} \n";
    }
}
