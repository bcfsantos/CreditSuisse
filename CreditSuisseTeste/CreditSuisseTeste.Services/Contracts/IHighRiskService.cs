namespace CreditSuisseTeste.Services
{
    public interface IHighRiskService
    {
        IList<string> isHighRisk(IList<string> listTradeHighRisk);

    }
}
