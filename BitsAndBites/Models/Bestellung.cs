using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsAndBites.Models;

public class Bestellung
{
    private const decimal CardRabatt = 0.95m;
    public bool BitAndBiteCard { get; set; }

    public List<Posten> Bestellposten { get; set; }

    public Bestellung()
    {
        Bestellposten = new List<Posten>();
    }

    public void PostenHinzufuegen(Posten posten)
    {
        Bestellposten.Add(posten);
    }
    public decimal BerechneBestellung()
    {
        decimal gesamtbetrag = 0;

        foreach (Posten posten in Bestellposten)
        {
            gesamtbetrag += posten.BerechnePreis();
        }

        if (BitAndBiteCard)
        {
            gesamtbetrag *= CardRabatt;
        }

        return decimal.Round(gesamtbetrag, 2);

    }
}
