namespace CreditSuisseTeste.Domain
{
    public interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }
        DateTime NextPaymentDate { get; }
        Trade GetTrade(string itemTrade);

    }
}
