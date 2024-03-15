namespace animal_sounds.Animals.Base;

public class Animal(string name, string sound)
{
    protected readonly string name = name;
    protected readonly string sound = sound;

    protected void MakeSound()
    {
        Console.WriteLine($"{name} makes the sound *{sound}*.");
    }
}
