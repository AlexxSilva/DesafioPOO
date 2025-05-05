using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO1.ZOO.Classes
{
    public class Elefante : Animal
    {
        public Elefante(int saudadeInicial) : base(saudadeInicial)
        {
        }

        public override void Alimentar()
        {
            Console.WriteLine($"Alimentando o elefante: {Nome}");
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"Elefante {Nome} berrando ...");
        }
    }
}
