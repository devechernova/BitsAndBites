using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitsAndBites.Models;

namespace BitsAndBites.Services;

public class KonsolenMenue
{
    private Bestellung bestellung;

    public KonsolenMenue()
    {
        bestellung = new Bestellung();
    }

    public void Start()
    {
        bool beendet = false;

        while (!beendet)
        {
            Console.Clear();

            Console.WriteLine("=== Bits & Bites - Bestellung ===");
            Console.WriteLine("1. Getränk hinzufügen");
            Console.WriteLine("2. Essen hinzufügen");
            Console.WriteLine("3. Internetticket hinzufügen");
            Console.WriteLine("4. Posten entfernen");
            Console.WriteLine("5. Bestellung anzeigen");
            Console.WriteLine("6. Bits & Bites-Card an/aus");
            Console.WriteLine("7. Bestellung an Theke übermitteln");
            Console.WriteLine("8. Beenden");
            Console.WriteLine();

            Console.Write("Auswahl: ");

            string? eingabe = Console.ReadLine();

            switch (eingabe)
            {
                case "1":
                    GetraenkHinzufuegen();
                    break;

                case "2":
                    EssenHinzufuegen();
                    break;

                case "3":
                    TicketHinzufuegen();
                    break;

                case "4":
                    PostenEntfernen();
                    break;

                case "5":
                    BestellungAnzeigen();
                    break;

                case "6":
                    CardUmschalten();
                    break;

                case "7":
                    BestellungUebermitteln();
                    break;

                case "8":
                    beendet = true;
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe.");
                    break;
            }

            if (!beendet)
            {
                Console.WriteLine();
                Console.WriteLine("Taste drücken...");
                Console.ReadKey();
            }
        }
    }
    private decimal PreisEinlesen()
    {
        while (true)
        { 
            string? eingabe = Console.ReadLine();

            eingabe = eingabe?.Replace('.', ',');

            if (decimal.TryParse(eingabe, out decimal preis))
            {
                return preis;
            }

            Console.Write("Ungültiger Preis. Bitte erneut eingeben: ");
        }
    }
    private int ZahlEinlesen()
    {
        while (true)
        {
            string? eingabe = Console.ReadLine();

            if (int.TryParse(eingabe, out int zahl))
            {
                return zahl;
            }

            Console.Write("Ungültige Zahl. Bitte erneut eingeben: ");
        }
    }
    private bool BoolEinlesen()
    {
        while (true)
        {
            string? eingabe = Console.ReadLine()?.ToLower();

            if (eingabe == "t")
            {
                return true;
            }

            if (eingabe == "f")
            {
                return false;
            }

            Console.Write("Bitte t oder f eingeben: ");
        }
    }
    private void GetraenkHinzufuegen()
    {
        Console.Write("Name: ");
        string? name = Console.ReadLine();

        Console.Write("Preis: ");
        decimal preis = PreisEinlesen();

        Console.Write("Alkoholisch (t(rue)/f(alse)): ");
        bool alkoholisch = BoolEinlesen();

        Console.Write("Happy Hour (t(rue)/f(alse)): ");
        bool happyHour = BoolEinlesen();

        Getraenk getraenk = new Getraenk(
            name!,
            preis,
            alkoholisch,
            happyHour);

        bestellung.PostenHinzufuegen(getraenk);

        Console.WriteLine();
        Console.WriteLine("Getränk wurde hinzugefügt.");


    }
    private void BestellungAnzeigen()
    {
        Console.WriteLine();
        Console.WriteLine("=== Aktuelle Bestellung ===");
        Console.WriteLine();

        foreach (Posten posten in bestellung.Bestellposten)
        {
            Console.WriteLine(
                $"{posten.Name} - {posten.BerechnePreis()} €");
        }

        Console.WriteLine();

        Console.WriteLine($"Card: {bestellung.BitAndBiteCard}");

        Console.WriteLine(
            $"Gesamtbetrag: {bestellung.BerechneBestellung()} €");
    }
    private void EssenHinzufuegen()
    {
        Console.Write("Name: ");
        string? name = Console.ReadLine();

        Console.Write("Preis: ");
        decimal preis = PreisEinlesen();

        Console.Write("Extra Groß (t(rue)/f(alse)): ");
        bool extragross = BoolEinlesen();

        Essen essen = new Essen(
            name!,
            preis,
            extragross);

        bestellung.PostenHinzufuegen(essen);

        Console.WriteLine();
        Console.WriteLine("Essen wurde hinzugefügt.");
    }
    private void TicketHinzufuegen()
    {
        Console.Write("Name: ");
        string? name = Console.ReadLine();

        Console.Write("Preis pro Minute: ");
        decimal preis = PreisEinlesen();

        Console.Write("Startstunde: ");
        int stunde = ZahlEinlesen();

        Console.Write("Startminute: ");
        int minute = ZahlEinlesen();

        Console.Write("Minuten: ");
        int minuten = ZahlEinlesen();

        DateTime startzeit = DateTime.Today
            .AddHours(stunde)
            .AddMinutes(minute);

        Ticket ticket = new Ticket(
            name!,
            preis,
            startzeit,
            minuten);

        bestellung.PostenHinzufuegen(ticket);

        Console.WriteLine();
        Console.WriteLine("Ticket wurde hinzugefügt.");
    }
    private void CardUmschalten()
    {
        bestellung.BitAndBiteCard = !bestellung.BitAndBiteCard;

        Console.WriteLine();

        if (bestellung.BitAndBiteCard)
        {
            Console.WriteLine("Bits & Bites-Card aktiviert.");
        }
        else
        {
            Console.WriteLine("Bits & Bites-Card deaktiviert.");
        }
    }
    private void PostenEntfernen()
    {
        if (bestellung.Bestellposten.Count == 0)
        {
            Console.WriteLine("Keine Posten vorhanden.");
            return;
        }

        Console.WriteLine("=== Posten entfernen ===");
        Console.WriteLine();

        for (int i = 0; i < bestellung.Bestellposten.Count; i++)
        {
            Console.WriteLine(
                $"{i + 1}. {bestellung.Bestellposten[i].Name}");
        }

        Console.WriteLine();
        Console.Write("Nummer: ");

        int nummer = ZahlEinlesen();

        if (nummer < 1 || nummer > bestellung.Bestellposten.Count)
        {
            Console.WriteLine("Ungültige Nummer.");
            return;
        }

        bestellung.Bestellposten.RemoveAt(nummer - 1);

        Console.WriteLine();
        Console.WriteLine("Posten wurde entfernt.");
    }
    private void BestellungUebermitteln()
    {
        Console.WriteLine();
        Console.WriteLine("=== Bestellung übermittelt ===");
        Console.WriteLine();

        Console.WriteLine($"Zeitpunkt: {DateTime.Now}");
        Console.WriteLine();

        foreach (Posten posten in bestellung.Bestellposten)
        {
            Console.WriteLine(
                $"{posten.Name} - {posten.BerechnePreis()} €");
        }

        Console.WriteLine();

        if (bestellung.BitAndBiteCard)
        {
            Console.WriteLine("Bits & Bites-Card aktiv");
        }

        Console.WriteLine(
            $"Gesamtbetrag: {bestellung.BerechneBestellung()} €");

        bestellung = new Bestellung();

        Console.WriteLine();
        Console.WriteLine("Neue Bestellung wurde gestartet.");
    }
}
