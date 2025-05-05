using DesafioPOO1.ZOO.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n--- Exibindo todos os animais ---\n");

        Zoologico zoo = new Zoologico();

        Animal animal1 = new Leao(50) { Nome = "Alex", Especie = "Mamífero", Idade = 10, };
        Animal animal2 = new Cobra(30) { Nome = "Raia", Especie = "Cascavel", Idade = 80, };
        Animal animal3 = new Elefante (80) { Nome = "Joso", Especie = "Milenar", Idade = 120, };

        zoo.AdicionarAnimal(animal1);
        zoo.AdicionarAnimal(animal2);
        zoo.AdicionarAnimal(animal3);

        zoo.ExibirTodosOsAnimais();
        zoo.AlimentarTodosOsAnimais();
        zoo.EmitirSomDeTodosAnimais();

        zoo.RealizaTratamentos(new Veterinario());

        Console.WriteLine("\n--- Exibindo todos os animais após tratamento ---\n");
        zoo.ExibirTodosOsAnimais();
    }
}