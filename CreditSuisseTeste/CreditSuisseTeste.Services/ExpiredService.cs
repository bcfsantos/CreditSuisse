using CreditSuisseTeste.Domain;

namespace CreditSuisseTeste.Services
{
    public class ExpiredService : IExpiredService
    {
        private readonly string _category = "Expire";
        private readonly ITrade _tradeExpired;

        public ExpiredService(ITrade tradeExpired)
        {
            _tradeExpired = tradeExpired;
        }
        public IList<string> isExpired(IList<string> listTradeExpired, DateTime paymentDate)
        {
            var listExpired = new List<string>();

            foreach (var tradeExpired in listTradeExpired)
            {
                var trade = _tradeExpired.GetTrade(tradeExpired);
                var isExpired = paymentDate.Subtract(trade.NextPaymentDate).TotalDays > 30;
                if (isExpired)
                    listExpired.Add(_category);
            }
            return listExpired;


        }
    }
}
