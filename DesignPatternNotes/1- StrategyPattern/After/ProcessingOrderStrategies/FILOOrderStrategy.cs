namespace DesignPatternNotes._1__StrategyPattern.After.ProcessingOrderStrategies;

public class FILOOrderStrategy : IProcessingOrderStrategy
{
    public IList<SupportTicket> RunStrategy(IList<SupportTicket> list)
    {
        return new List<SupportTicket>(list.Reverse());
    }
}