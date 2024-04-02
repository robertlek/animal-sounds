using animal_sounds.Animals.Base;

namespace animal_sounds.Animals;

public class Chicken : Animal, IAnimal
{
    public Chicken()
    {
        SetType<Chicken>();
        SetSound("cluck");
    }
}
