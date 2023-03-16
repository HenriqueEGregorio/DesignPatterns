using ChainOfResponsibility.Models;
using ChainOfResponsibility.Services;

CalculateDiscounts calculate = new CalculateDiscounts();

Budget budget = new Budget(500);
budget.AddsItem(new Item("Canete", 250));
budget.AddsItem(new Item("Lapis", 250));
double discount = calculate.Calculate(budget);

Console.WriteLine(discount);