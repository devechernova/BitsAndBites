using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsAndBites.Models;

public abstract class Posten
{
    public string Name { get; set; }
    public double Preis { get; set; }

    protected Posten(string name, double preis)
    {
        Name=name;
        Preis=preis;
    }

    public abstract double BerechnePreis();
}
