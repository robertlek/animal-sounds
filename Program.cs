using animal_sounds.Animals;
using animal_sounds.Animals.Base;

List<IAnimal> animals =
[
    new Cat("Cat", "meow"),
    new Chicken("Chicken", "cluck"),
    new Dog("Dog", "bark"),
    new Horse("Horse", "neigh"),
    new Sheep("Sheep", "bleat")
];

foreach (var animal in animals)
{
    animal.MakeSound();
}
