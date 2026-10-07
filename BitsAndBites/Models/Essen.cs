using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsAndBites.Models;

public class Essen : Posten
{
    public bool Extragross {  get; set; }

    public Essen (
        string name,
        double preis,
        bool extragross)
        : base(name, preis)
    {
        Extragross = extragross;
    }
    public override double BerechnePreis()
    {
        if (Extragross)
        {
            return Preis * 1.20;
        }

        return Preis;
    }

}
