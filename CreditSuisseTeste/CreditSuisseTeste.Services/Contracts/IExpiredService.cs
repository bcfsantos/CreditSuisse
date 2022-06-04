namespace CreditSuisseTeste
{
    public interface IExpiredService
    {
        IList<string> isExpired(IList<string> listTradeExpired, DateTime paymentDate);
    }
}
