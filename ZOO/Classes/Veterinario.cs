using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO1.ZOO.Classes
{
    public class Veterinario
    {
        public void TratarAnimal(Animal animal)
        {
            if (animal.ObterSaude() < 50)
            {
                animal.AumentarSaude(10);
            }
        }
    }
}
