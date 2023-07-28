namespace N14.OverridingMethods;

public class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Making sound as bird");
    }
}