using DesignPatternNotes._2___DependencyInversion.After;
using old_ElectricPowerSwitch = DesignPatternNotes._2___DependencyInversion.Before.ElectricPowerSwitch;
using old_LightBulb = DesignPatternNotes._2___DependencyInversion.Before.LightBulb;

namespace DesignPatternNotes._2___DependencyInversion;

public static class DependencyInversionExample
{
    public static void RunBefore()
    {
        var powerSwitch = new old_ElectricPowerSwitch(new old_LightBulb());
        powerSwitch.Press();
        powerSwitch.Press();
        powerSwitch.Press();
    }

    public static void RunAfter()
    {
        var powerSwitch = new ElectricPowerSwitch(new LightBulb());
        powerSwitch.Press();
        powerSwitch.Press();
        powerSwitch.Press();
        
        var powerSwitch2 = new ElectricPowerSwitch(new Fan());
        powerSwitch2.Press();
        powerSwitch2.Press();
        powerSwitch2.Press();
    }
}