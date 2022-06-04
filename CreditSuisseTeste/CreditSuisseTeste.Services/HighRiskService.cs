using CreditSuisseTeste.Domain;

namespace CreditSuisseTeste.Services
{
    public class HighRiskService : IHighRiskService
    {
        private readonly string _category = "HighRisk";
        private readonly ITrade _tradeHighRisk;

        public HighRiskService(ITrade tradeHighRisk)
        {
            _tradeHighRisk = tradeHighRisk;
        }

        public IList<string> isHighRisk(IList<string> listTradeHighRisk)
        {
            var listHighRisk = new List<string>();

            foreach (var tradeHighRisk in listTradeHighRisk)
            {
                var trade = _tradeHighRisk.GetTrade(tradeHighRisk);
                var isHighRisk = trade.Value > 1000 && trade.ClientSector == Sector.Private.ToString();
                if (isHighRisk)
                    listHighRisk.Add(_category);

            }
            return listHighRisk;


        }
    }
}
