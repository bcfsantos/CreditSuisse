namespace CreditSuisse.Domain
{
    public class MediumRisk
    {
        private readonly ITrade<MediumRisk> _trade;
        public MediumRisk(ITrade<MediumRisk> trade)
        {
            _trade = trade;
        }
        public string isMediumRisk(ITrade<MediumRisk> trade)
        {
            var isMediumRisk = trade.Value > 1000 && trade.ClientSector == Sector.Public.ToString();
            return isMediumRisk ? trade.GetCategory(this) : String.Empty;
        }
    }
}
