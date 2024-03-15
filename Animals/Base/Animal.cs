namespace animal_sounds.Animals.Base;

public abstract class Animal(string name, string sound)
{
    protected readonly string name = name;
    protected readonly string sound = sound;

    public void MakeSound()
    {
        Console.WriteLine($"{name} makes the sound *{sound}*.");
    }
}
