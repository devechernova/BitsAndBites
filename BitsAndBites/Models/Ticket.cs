using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsAndBites.Models;

internal class Ticket : Posten
{
    public DateTime Startzeit { get; set; }

    public int Minuten { get; set; }
    public DateTime Endzeit
    {
        get
        {
            return Startzeit.AddMinutes(Minuten);
        }
    }

    public Ticket(
    string name,
    decimal preis,
    DateTime startzeit,
    int minuten)
    : base(name, preis)
    {
        Startzeit = startzeit;
        Minuten = minuten;
    }

    public override decimal BerechnePreis()
    {
        return decimal.Round(Preis * Minuten, 2);
    }
}
