using CreditSuisseTeste.Domain;

namespace CreditSuisseTeste.Services
{
    public class MediumRiskService : IMediumRiskService
    {
        private readonly string _category = "MediumRisk";
        private readonly ITrade _tradeMediumRisk;
        public MediumRiskService(ITrade tradeMediumRisk)
        {
            _tradeMediumRisk = tradeMediumRisk;
        }
        public string isMediumRisk(string tradeMediumRisk)
        {
            var trade = _tradeMediumRisk.GetTrade(tradeMediumRisk);
            var isMediumRisk = trade.NextPaymentDate.Subtract(trade.NextPaymentDate).TotalDays > 30;
            return isMediumRisk ? this.GetType().Name : String.Empty;
        }
        public IList<string> isMediumRisk(IList<string> listTradeMediumRisk)
        {
            var listMediumRisk = new List<string>();

            foreach (var tradeMediumRisk in listTradeMediumRisk)
            {
                var trade = _tradeMediumRisk.GetTrade(tradeMediumRisk);
                var isMediumRisk = trade.Value > 1000000 && trade.ClientSector == Sector.Public.ToString();
                if (isMediumRisk)
                    listMediumRisk.Add(_category);
            }
            return listMediumRisk;


        }
    }
}
