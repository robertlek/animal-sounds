using animal_sounds.Animals.Base;

namespace animal_sounds.Animals;

public class Cat : Animal, IAnimal
{
    public Cat()
    {
        SetType<Cat>();
        SetSound("meow");
    }
}
