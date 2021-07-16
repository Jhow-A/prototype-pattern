using PrototypeShallowCopy.ConcretePrototype;
using System;

namespace PrototypeShallowCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            var soldado = new Soldado()
            {
                Nome = "Soldado",
                Arma = "Fuzil HK G36",
                Acessorio = new Acessorio() { Nome = "Visor Noturno" }
            };

            // Clone 1
            var clone1 = soldado.Clone() as Soldado;
            clone1.Nome = "Soldado Clone 1";
            clone1.Arma = "Fuzil Kalashinikov";
            clone1.Acessorio.Nome = "Colete especial";

            // Clone 2
            var clone2 = soldado.Clone() as Soldado;
            clone2.Nome = "Soldado Clone 2";
            clone2.Arma = "Fuzil AK105";
            clone2.Acessorio.Nome = "Bandoleira";

            // Exibindo objetos (clona a referência de Acessorio porque é um tipo complexo)
            Console.WriteLine("Soldado: ");
            Console.WriteLine(soldado.ToString());

            Console.WriteLine("Clone 1: ");
            Console.WriteLine(clone1.ToString());

            Console.WriteLine("Clone 2: ");
            Console.WriteLine(clone2.ToString());
        }
    }
}
