using BitsAndBites.Models;
namespace BitsAndBites;

internal class Program
{
    static void Main(string[] args)
    {
        var bier = new Getraenk(
"Bier",
4.0m,
true,
true);

        Console.WriteLine(bier.BerechnePreis());

        Essen pizza = new Essen(
"Pizza",
8.50m,
true);

        Console.WriteLine(pizza.BerechnePreis());

        Ticket ticket = new Ticket(
"Kurzticket",
0.05m,
DateTime.Today.AddHours(14),
60);


        Bestellung bestellung = new Bestellung();

        bestellung.PostenHinzufuegen(bier);
        bestellung.PostenHinzufuegen(pizza);
        bestellung.PostenHinzufuegen(ticket);

        bestellung.BitAndBiteCard = true;

        Console.WriteLine(bestellung.BerechneBestellung());

        Console.WriteLine(ticket.BerechnePreis());
    }
}
