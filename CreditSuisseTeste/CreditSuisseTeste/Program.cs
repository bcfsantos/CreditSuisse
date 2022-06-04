#region Using
using CreditSuisseTeste;
using CreditSuisseTeste.Domain;
using CreditSuisseTeste.Services;
using Microsoft.Extensions.DependencyInjection;
#endregion

#region Register
var services = new ServiceCollection();
services.AddTransient<ITrade, Trade>();
services.AddTransient<ITrade, Expired>();
services.AddTransient<ITrade, HighRisk>();
services.AddTransient<ITrade, MediumRisk>();
services.AddTransient<IExpiredService, ExpiredService>();
services.AddTransient<IHighRiskService, HighRiskService>();
services.AddTransient<IMediumRiskService, MediumRiskService>();

var sp = services.BuildServiceProvider();

#endregion

#region Input
var listCategory = new List<string>();
Console.WriteLine("Payment Date: mm/dd/yyyy");
var paymentDateInput = Console.ReadLine();
var paymentDate = CreditSuisseTeste.Validator.Validator.DateValidate(paymentDateInput, "Payment Date is not valide");

Console.WriteLine("Number of trade: ");
int trades;
var numberInput = Console.ReadLine();
var listTrade = new List<string>();

if (int.TryParse(numberInput?.ToString(), out trades))
{
    Console.WriteLine("Value trade, Client Sector and Next Payment Date (Separated by space)");
    while (trades > 0)
    {
        trades--;
        var trade = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(trade?.ToString()))
            listTrade.Add(trade.ToString());
    }
}

#endregion

#region ValidateCategory
var _expired = sp.GetRequiredService<IExpiredService>();
var _listExpired = _expired.isExpired(listTrade, paymentDate);
if (_listExpired is not null)
    listCategory.AddRange(_listExpired);

var _highRisk = sp.GetRequiredService<IHighRiskService>();
var _listHighRisk = _highRisk.isHighRisk(listTrade);
if (_listHighRisk is not null)
    listCategory.AddRange(_listHighRisk);

var _mediumRisk = sp.GetRequiredService<IMediumRiskService>();
var _listMediumRisk = _mediumRisk.isMediumRisk(listTrade);
if (_listMediumRisk is not null)
    listCategory.AddRange(_listMediumRisk);
#endregion

#region OutPut
Console.Clear();
foreach (var item in listCategory)
{
    Console.WriteLine(item);
}
Console.ReadKey();
#endregion

