namespace DesignPatternNotes._1__StrategyPattern.After.ProcessingOrderStrategies;

public interface IProcessingOrderStrategy
{
    public IList<SupportTicket> RunStrategy(IList<SupportTicket> list);
}