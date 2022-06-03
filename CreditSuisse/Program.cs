using CreditSuisse.Domain;

//private readonly ITrade<Expired>? _tradeExpired;
//private readonly ITrade<Highrisk>? _tradeHighrisk;
//private readonly ITrade<MediumRisk>? _tradeMediumRisk;

Console.WriteLine("Paymente Date:");
DateTime _paymentDate;
DateTime.TryParse(Console.ReadLine(), out _paymentDate);
Console.WriteLine("Paymente Date:");
int _numberTrage;
int.TryParse(Console.ReadLine(), out _numberTrage);

Console.WriteLine($"Amount Trade {_numberTrage}.");
Console.WriteLine($"Separated by a space Valude Sector and Next Payment Date");

for (int i = 0; i < _numberTrage; i++)
{
    var trade = Console.ReadLine()?.Split(' ');
    Console.WriteLine("Next trade");
}
