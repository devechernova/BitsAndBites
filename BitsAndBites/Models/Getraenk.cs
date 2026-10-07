using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsAndBites.Models;

public class Getraenk : Posten
{
    public bool Alkoholisch {  get; set; }
    public bool HappyHour { get; set; }

    public Getraenk(
        string name,
        decimal preis,
        bool alkoholisch,
        bool happyHour)
        : base(name, preis)
        {
        Alkoholisch = alkoholisch;
        HappyHour = happyHour;  
    }
    public override double BerechnePreis()
    {
        if (Alkoholisch && HappyHour)
        {
            return Preis * 0.75m;
        }

        return Preis;
    }


}
