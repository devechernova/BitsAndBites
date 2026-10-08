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
                    Console.WriteLine("Noch nicht implementiert.");
                    break;

                case "2":
                    Console.WriteLine("Noch nicht implementiert.");
                    break;

                case "3":
                    Console.WriteLine("Noch nicht implementiert.");
                    break;

                case "4":
                    Console.WriteLine("Noch nicht implementiert.");
                    break;

                case "5":
                    Console.WriteLine("Noch nicht implementiert.");
                    break;

                case "6":
                    Console.WriteLine("Noch nicht implementiert.");
                    break;

                case "7":
                    Console.WriteLine("Noch nicht implementiert.");
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
}
