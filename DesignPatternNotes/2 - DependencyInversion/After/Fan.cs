namespace DesignPatternNotes._2___DependencyInversion.After;

public class Fan : ISwitchable
{
    public void TurnOn()
    {
        Console.WriteLine("Fan is turned on!");
    }

    public void TurnOff()
    {
        Console.WriteLine("Fan is turned off!");
    }
}