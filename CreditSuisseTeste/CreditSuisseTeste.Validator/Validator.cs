using CreditSuisseTeste.Common;
using System.Globalization;

namespace CreditSuisseTeste.Validator
{
    public class Validator
    {
        public static double FormatValue(string value, string message)
        {
            double _value;

            if (double.TryParse(value, out _value))
                return _value;
            else
                throw new Exception(message);

            // return Convert.ToDouble(_value.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

        }
        public static string GetSector(string clientSector, string message)
        {
            return Enum.IsDefined(typeof(Sector), clientSector) ? clientSector : throw new Exception(message);
        }

        public static DateTime DateValidate(string value, string message)
        {
            DateTime _value;

            if (DateTime.TryParse(value, CultureInfo.CreateSpecificCulture("en-US"), DateTimeStyles.None, out _value))
                return _value;
            else
                throw new Exception(message);

        }
    }

}