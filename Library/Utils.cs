using animal_sounds.Animals.Base;
using animal_sounds.Animals;

namespace animal_sounds.Library;

public static class Utils
{
    public static IEnumerable<IAnimal> GetAnimals()
    {
        return [new Cat(), new Chicken(), new Dog(), new Horse(), new Sheep()];
    }
}
