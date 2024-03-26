using animal_sounds.Animals.Base;
using animal_sounds.Library;

foreach (IAnimal animal in Utils.GetAnimals())
{
    animal.MakeSound();
}
