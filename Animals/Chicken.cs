using animal_sounds.Animals.Base;

namespace animal_sounds.Animals;

public class Chicken(string name, string sound) : Animal(name, sound), IAnimal
{
}
