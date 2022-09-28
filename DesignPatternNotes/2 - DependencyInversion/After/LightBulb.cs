namespace DesignPatternNotes._2___DependencyInversion.After;

public class LightBulb : ISwitchable
{
    public void TurnOn()
    {
        Console.WriteLine("Light bulb is turned on!");
    }

    public void TurnOff()
    {
        Console.WriteLine("Light bulb is turned off!");
    }
}