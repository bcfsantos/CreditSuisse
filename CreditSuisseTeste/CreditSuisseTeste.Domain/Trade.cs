namespace CreditSuisseTeste.Domain
{
    public class Trade : ITrade
    {

        private readonly ITrade? _trade;
        public Trade(ITrade trade)
        {
            _trade = trade;
        }
        public Trade()
        {

        }
        double _value;
        public double Value
        {
            get => _value;
            set => _value = value;
        }
        string _clientSector = String.Empty;
        public string ClientSector
        {
            get => _clientSector;
            set => _clientSector = value;
        }
        DateTime _nextPaymentDate;
        public DateTime NextPaymentDate
        {
            get => _nextPaymentDate;
            set => _nextPaymentDate = value;
        }

        public Trade GetTrade(string itemTrade)
        {
            var trade = itemTrade.Split(' ');
            var getTrade = new Trade
            {
                Value = Validator.Validator.FormatValue(trade[0], "Value is not valide"),
                ClientSector = Validator.Validator.GetSector(trade[1], "Sector is not valide"),
                NextPaymentDate = Validator.Validator.DateValidate(trade[2], "Next Payment Date is not valide"),
            };
            return getTrade;

        }
    }
}
