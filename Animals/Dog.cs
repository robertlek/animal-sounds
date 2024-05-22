using animal_sounds.Animals.Base;

namespace animal_sounds.Animals;

public class Dog : Animal, IAnimal
{
    public Dog()
    {
        SetType<Dog>();
        SetSound("bark");
    }
}
