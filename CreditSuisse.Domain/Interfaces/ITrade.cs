namespace CreditSuisse.Domain
{
    public interface ITrade<T>
    {
        double Value { get; }
        string ClientSector { get; }
        DateTime NextPaymentDate { get; }
        DateTime PaymentDate { get; }
        string GetCategory(T obj);
    }
}
