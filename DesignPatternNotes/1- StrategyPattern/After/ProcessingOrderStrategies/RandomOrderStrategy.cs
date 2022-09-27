namespace DesignPatternNotes._1__StrategyPattern.After.ProcessingOrderStrategies;

public class RandomOrderStrategy : IProcessingOrderStrategy
{
    public IList<SupportTicket> RunStrategy(IList<SupportTicket> list)
    {
        return new List<SupportTicket>(ShuffleTickets(list));
    }
    
    private IList<SupportTicket> ShuffleTickets(IList<SupportTicket> unshuffledTickets)
    {
        var r = new Random();
        return unshuffledTickets.OrderBy(x => r.Next()).ToList();
    }
}