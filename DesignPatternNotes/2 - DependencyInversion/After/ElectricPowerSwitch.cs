namespace DesignPatternNotes._2___DependencyInversion.After;

public class ElectricPowerSwitch
{
    private readonly ISwitchable _switchable;
    private bool _on;

    public ElectricPowerSwitch(ISwitchable switchable)
    {
        _switchable = switchable;
        _on = false;
    }

    public void Press()
    {
        if (_on)
            _switchable.TurnOff();
        else
            _switchable.TurnOn();

        _on = !_on;
    }
}