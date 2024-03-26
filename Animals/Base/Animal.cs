namespace animal_sounds.Animals.Base;

public abstract class Animal(string name, string sound) : IAnimal
{
    protected string Name { get; } = name;
    protected string Sound { get; } = sound;

    public void MakeSound()
    {
        Console.WriteLine($"{Name} makes the sound *{Sound}*.");
    }
}
