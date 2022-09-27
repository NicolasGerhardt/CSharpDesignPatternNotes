namespace DesignPatternNotes._1__StrategyPattern.before;

public class CustomerSupport
{
    private string _processingStrategy;
    private IList<SupportTicket> _tickets;

    public CustomerSupport(string processingStrategy = "fifo")
    {
        _tickets = new List<SupportTicket>();
        _processingStrategy = processingStrategy;
    }

    public void CreateTicket(string customer, string issue)
    {
        _tickets.Add(new SupportTicket(customer, issue));
    }

    public void ProcessTickets()
    {
        if (_tickets.Count == 0)
        {
            Console.WriteLine("No Tickets to process");
            return;
        }

        if (_processingStrategy == "fifo")
        {
            foreach (var ticket in _tickets)
            {
                ProcessTicket(ticket);   
            }
        }
        else if (_processingStrategy == "filo")
        {
            foreach (var ticket in _tickets.Reverse())
            {
                ProcessTicket(ticket);
            }
        }
        else if (_processingStrategy == "random")
        {
            foreach (var ticket in ShuffleTickets(_tickets))
            {
                ProcessTicket(ticket);
            }
        }
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