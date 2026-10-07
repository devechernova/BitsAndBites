using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsAndBites.Models;

public abstract class Posten
{
    public string Name { get; set; }
    public decimal Preis { get; set; }

    protected Posten(string name, decimal preis)
    {
        Name=name;
        Preis=preis;
    }

    public abstract decimal BerechnePreis();
}
