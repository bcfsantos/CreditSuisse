namespace CreditSuisse.Domain
{
    public class Expired
    {
        private readonly ITrade<Expired> _trade;
        public Expired(ITrade<Expired> trade)
        {
            _trade = trade;
        }
        public string isExpired(ITrade<Expired> trade)
        {
            var isExpired = trade.NextPaymentDate.Subtract(trade.NextPaymentDate).TotalDays > 30;
            return isExpired ? trade.GetCategory(this) : String.Empty;
        }
    }
}
