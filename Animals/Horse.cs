using animal_sounds.Animals.Base;

namespace animal_sounds.Animals;

public class Horse : Animal, IAnimal
{
    public Horse()
    {
        SetType<Horse>();
        SetSound("neigh");
    }
}
