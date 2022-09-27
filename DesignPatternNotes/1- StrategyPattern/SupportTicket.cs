namespace DesignPatternNotes._1__StrategyPattern;

public class SupportTicket
{
    public Guid Id;
    public string Customer;
    public string Issue;

    public SupportTicket(string customer, string issue)
    {
        Id = Guid.NewGuid();
        Customer = customer;
        Issue = issue;
    }
}