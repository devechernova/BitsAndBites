using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsAndBites.Models;

public class Getraenk : Posten
{
    private const decimal HappyHourRabatt = 0.75m;
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
    public override decimal BerechnePreis()
    {
        if (Alkoholisch && HappyHour)
        {
            return decimal.Round(Preis * HappyHourRabatt, 2);
        }

        return Preis;
    }


}
