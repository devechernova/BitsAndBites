using BitsAndBites.Models;
using BitsAndBites.Services;

namespace BitsAndBites;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        KonsolenMenue menue = new KonsolenMenue();

        menue.Start();
    }

}
       


/* var bier = new Getraenk(
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

         Console.WriteLine(ticket.BerechnePreis()); */



        /*Console.WriteLine("=== Test 1 ===");

           Getraenk cola = new Getraenk(
               "Cola",
               3.0m,
               false,
               true);

           Console.WriteLine($"Ergebnis: {cola.BerechnePreis()}");
           Console.WriteLine("Erwartet: 3.00");
           Console.WriteLine();

           Console.WriteLine("=== Test 2 ===");

           Getraenk bierOhneHappyHour = new Getraenk(
               "Bier",
               4.0m,
               true,
               false);

           Console.WriteLine($"Ergebnis: {bierOhneHappyHour.BerechnePreis()}");
           Console.WriteLine("Erwartet: 4.00");
           Console.WriteLine();

           Console.WriteLine("=== Test 3 ===");

           Getraenk bierMitHappyHour = new Getraenk(
               "Bier",
               4.0m,
               true,
               true);

           Console.WriteLine($"Ergebnis: {bierMitHappyHour.BerechnePreis()}");
           Console.WriteLine("Erwartet: 3.00");
           Console.WriteLine();

           Console.WriteLine("=== Test 4 ===");

           Essen pizzaNormal = new Essen(
               "Pizza",
               8.5m,
               false);

           Console.WriteLine($"Ergebnis: {pizzaNormal.BerechnePreis()}");
           Console.WriteLine("Erwartet: 8.50");
           Console.WriteLine();

           Console.WriteLine("=== Test 5 ===");

           Essen pizzaExtraGross = new Essen(
               "Pizza",
               8.5m,
               true);

           Console.WriteLine($"Ergebnis: {pizzaExtraGross.BerechnePreis()}");
           Console.WriteLine("Erwartet: 10.20");
           Console.WriteLine();

           Console.WriteLine("=== Test 6 ===");

           Ticket ticket = new Ticket(
               "Kurzticket",
               0.05m,
               DateTime.Today.AddHours(14),
               60);

           Console.WriteLine($"Ergebnis: {ticket.BerechnePreis()}");
           Console.WriteLine("Erwartet: 3.00");
           Console.WriteLine();

           Console.WriteLine("=== Test 7 ===");

           Bestellung bestellungOhneCard = new Bestellung();

           bestellungOhneCard.PostenHinzufuegen(bierMitHappyHour);
           bestellungOhneCard.PostenHinzufuegen(pizzaExtraGross);
           bestellungOhneCard.PostenHinzufuegen(ticket);

           Console.WriteLine($"Ergebnis: {bestellungOhneCard.BerechneBestellung()}");
           Console.WriteLine("Erwartet: 16.20");
           Console.WriteLine();

           Console.WriteLine("=== Test 8 ===");

           bestellungOhneCard.BitAndBiteCard = true;

           Console.WriteLine($"Ergebnis: {bestellungOhneCard.BerechneBestellung()}");
           Console.WriteLine("Erwartet: 15.39");
           Console.WriteLine();

           Console.WriteLine("=== Test 9 ===");

           Bestellung leereBestellung = new Bestellung();

           Console.WriteLine($"Ergebnis: {leereBestellung.BerechneBestellung()}");
           Console.WriteLine("Erwartet: 0.00"); */

