namespace N14.OverridingMethods;

public class Sparrow : Bird
{
    public override void MakeSound()
    {
        Console.WriteLine("Making sound as sparrow");
    }
}