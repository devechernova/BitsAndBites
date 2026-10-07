using BitsAndBites.Models;
namespace BitsAndBites;

internal class Program
{
    static void Main(string[] args)
    {
        var bier = new Getraenk(
"Bier",
4.0,
true,
true);

        Console.WriteLine(bier.BerechnePreis());

        Essen pizza = new Essen(
"Pizza",
8.50,
true);

        Console.WriteLine(pizza.BerechnePreis());
    }
}
