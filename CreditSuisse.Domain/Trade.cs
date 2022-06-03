namespace CreditSuisse.Domain
{
    public class Trade<T> : ITrade<T>
    {
        public Trade()
        {

        }
        public double Value => Validate.FormatValue(Value);

        public string ClientSector => Validate.GetSector(ClientSector, "Sector is not valide");

        public DateTime NextPaymentDate => NextPaymentDate;

        public DateTime PaymentDate => PaymentDate;

        public string GetCategory(T obj)
        {
            return obj?.GetType().Name ?? throw new Exception("Category is not found");

        }


    }
}
