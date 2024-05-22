namespace animal_sounds.Animals.Base;

public abstract class Animal : IAnimal
{
    protected string Type { get; set; } = null!;
    protected string Sound { get; set; } = null!;

    protected void SetType<T>() where T : class
    {
        Type = typeof(T).Name;
    }

    protected void SetSound(string sound)
    {
        Sound = sound;
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Type} makes the sound *{Sound}*.");
    }
}
