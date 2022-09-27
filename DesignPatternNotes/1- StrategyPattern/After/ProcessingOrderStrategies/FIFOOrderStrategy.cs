namespace DesignPatternNotes._1__StrategyPattern.After.ProcessingOrderStrategies;

public class FIFOOrderStrategy : IProcessingOrderStrategy
{
    public IList<SupportTicket> RunStrategy(IList<SupportTicket> list)
    {
        return new List<SupportTicket>(list);
    }
}