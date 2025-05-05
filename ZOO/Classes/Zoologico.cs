using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO1.ZOO.Classes
{
    public class Zoologico
    {
        List<Animal> animais = new List<Animal>();

        public void AdicionarAnimal(Animal animal)
        {
            animais.Add(animal);
        }

        public void AlimentarTodosOsAnimais()
        {
            foreach (Animal animal in animais)
            {
                animal.Alimentar();
            }
        }

        public void EmitirSomDeTodosAnimais()
        {
            foreach (Animal animal in animais)
            {
                animal.EmitirSom();
            }
        }
        public void ExibirTodosOsAnimais()
        {
            foreach (Animal animal in animais)
            {
                animal.ExibirInformacoes();
            }
        }

        public void RealizaTratamentos(Veterinario vet)
        {
            foreach (Animal animal in animais)
            {
                vet.TratarAnimal(animal);
            }
        }
    }
}
