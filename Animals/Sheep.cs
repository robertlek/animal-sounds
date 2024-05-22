using animal_sounds.Animals.Base;

namespace animal_sounds.Animals;

public class Sheep : Animal, IAnimal
{
    public Sheep()
    {
        SetType<Sheep>();
        SetSound("bleat");
    }
}
