using System;

namespace PrototypeDeepCopy.ConcretePrototype
{
    public class Acessorio : ICloneable
    {
        public string Nome { get; set; }

        public object Clone() => this.MemberwiseClone() as Acessorio;
    }
}
