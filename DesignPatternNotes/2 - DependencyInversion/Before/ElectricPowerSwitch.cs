namespace DesignPatternNotes._2___DependencyInversion.Before;

public class ElectricPowerSwitch
{
    private readonly LightBulb _blub;
    private bool _on;

    public ElectricPowerSwitch(LightBulb bulb)
    {
        _blub = bulb;
        _on = false;
    }

    public void Press()
    {
        if (_on)
            _blub.TurnOff();
        else
            _blub.TurnOn();

        _on = !_on;
    }
}