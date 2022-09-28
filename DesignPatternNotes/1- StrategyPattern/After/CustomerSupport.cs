using DesignPatternNotes._1__StrategyPattern.After.ProcessingOrderStrategies;

namespace DesignPatternNotes._1__StrategyPattern.After;

public class CustomerSupport
{
    private readonly IProcessingOrderStrategy _processingOrderStrategy;
    private readonly IList<SupportTicket> _tickets;

    public CustomerSupport(IProcessingOrderStrategy processingOrderStrategy)
    {
        _tickets = new List<SupportTicket>();
        _processingOrderStrategy = processingOrderStrategy;
    }

    public void CreateTicket(string customer, string issue)
    {
        _tickets.Add(new SupportTicket(customer, issue));
    }

    public void ProcessTickets()
    {
        if (!_tickets.Any())
        {
            Console.WriteLine("No Tickets to process");
            return;
        }

        var orderedList = _processingOrderStrategy.RunStrategy(_tickets);

        foreach (var ticket in orderedList) ProcessTicket(ticket);
    }

    private IList<SupportTicket> ShuffleTickets(IList<SupportTicket> unshuffledTickets)
    {
        var r = new Random();
        return unshuffledTickets.OrderBy(x => r.Next()).ToList();
    }

    private void ProcessTicket(SupportTicket ticket)
    {
        Console.WriteLine("==================================");
        Console.WriteLine($"Processing ticket id: {ticket.Id}");
        Console.WriteLine($"Customer: {ticket.Customer}");
        Console.WriteLine($"Issue: {ticket.Issue}");
        Console.WriteLine("==================================");
    }
}