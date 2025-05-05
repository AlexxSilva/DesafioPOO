using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO1.ZOO.Classes
{
    public abstract class Animal
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Especie { get; set; }
        private int Saude { get; set; }

        protected Animal(int saudadeInicial)
        {
            Saude = saudadeInicial;
        }

        public int ObterSaude()
        {
            return Saude;
        }
        public void AumentarSaude(int qtde)
        {
            if (Saude < 100)
            {
                Saude = Math.Min(100, Saude + qtde);
            }
            else
            {
                Console.WriteLine("Saude está no máximo");
            }
        }

        public void DiminuirSaude(int qtde)
        {
            if (Saude - qtde >= 0)
            {
                Saude -= qtde;
            }
            else
            {
                Console.WriteLine("A saúde não pode ficar negativa");
            }
        }

        public abstract void EmitirSom();
        public abstract void Alimentar();

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome} - Idade: {Idade} - Especie: {Especie} - Saude: {Saude}");
        }

    }
}
