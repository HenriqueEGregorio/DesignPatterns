using DesignPatterns_1.Models;
using DesignPatterns_1.Services;

var iss = new Iss();
var icms = new Icms();
var iccc = new Iccc();

var budget = new Budget(500.0);

for (int i = 0; budget.Value <= 3500 ; budget.Value += 500)
{
    new CalculateTaxes().Calculate(budget, iccc);
}

Console.ReadKey();