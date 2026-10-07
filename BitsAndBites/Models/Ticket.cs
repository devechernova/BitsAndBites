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

    public Ticket(
    string name,
    double preis,
    DateTime startzeit,
    int minuten)
    : base(name, preis)
    {
        Startzeit = startzeit;
        Minuten = minuten;
    }

    public override double BerechnePreis()
    {
        return Preis * Minuten;
    }
}
