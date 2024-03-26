using animal_sounds.Animals.Base;
using animal_sounds.Animals;

namespace animal_sounds.Library;

public static class Utils
{
    public static IEnumerable<IAnimal> GetAnimals()
    {
        return new List<IAnimal>()
        {
            new Cat("Cat", "meow"),
            new Chicken("Chicken", "cluck"),
            new Dog("Dog", "bark"),
            new Horse("Horse", "neigh"),
            new Sheep("Sheep", "bleat")
        };
    }
}
