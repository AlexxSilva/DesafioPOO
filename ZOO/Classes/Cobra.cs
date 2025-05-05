using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO1.ZOO.Classes
{
    public class Cobra : Animal
    {
        public Cobra(int saudadeInicial) : base(saudadeInicial)
        {
        }

        public override void Alimentar()
        {
            Console.WriteLine($"Alimentando a cobra: {Nome}");
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"Cobra {Nome} chocalhando ...");
        }
    }
}
