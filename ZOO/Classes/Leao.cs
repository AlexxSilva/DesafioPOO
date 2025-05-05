using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO1.ZOO.Classes
{
    public class Leao : Animal
    {
        public Leao(int saudadeInicial) : base(saudadeInicial)
        {
        }

        public override void Alimentar()
        {
            Console.WriteLine($"Alimentando o leão: {Nome}");
        }

        public override void EmitirSom()
        {

            Console.WriteLine($"Leão {Nome} Rugido ...");
        }

    }
}
