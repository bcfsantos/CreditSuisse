using System.Globalization;

namespace CreditSuisse.Domain
{
    public class Validate
    {
        public static double FormatValue(double value)
        {

            return Convert.ToDouble(value.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
        }
        public static string GetSector(string clientSector, string message)
        {

            return Enum.GetName(typeof(Sector), clientSector) ?? throw new Exception(message);
        }
    }
}
