using DesignPatternNotes._1__StrategyPattern.After.ProcessingOrderStrategies;
using CustomerSupportBefore = DesignPatternNotes._1__StrategyPattern.before.CustomerSupport;
using CustomerSupportAfter = DesignPatternNotes._1__StrategyPattern.After.CustomerSupport;

namespace DesignPatternNotes._1__StrategyPattern;

public static class StrategyPatternExample
{
    public static void RunBefore()
    {
        var app = new CustomerSupportBefore("random");

        app.CreateTicket("Alice", "the  key o my keyboard doe't work!!");
        app.CreateTicket("Bob", "There is no sound coming from my computer");
        app.CreateTicket("Craig", "I Installed linux and now I am a robot");

        app.ProcessTickets();
    }
    
    public static void RunAfter()
    {
        var app = new CustomerSupportAfter(new RandomOrderStrategy());

        app.CreateTicket("Alice", "the  key o my keyboard doe't work!!");
        app.CreateTicket("Bob", "There is no sound coming from my computer");
        app.CreateTicket("Craig", "I Installed linux and now I am a robot");

        app.ProcessTickets();
    }
}