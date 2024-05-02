using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvaDZedukos
{
    public class Korisnik : Osoba,IBankovniRacun
    {
        public int BrojRačuna { get; set; }
        public decimal StanjeRačuna { get; set; }

        public void Uplati(decimal iznos)
        {
            Console.WriteLine($"Korisnik {BrojRačuna} uplaćuje {iznos}");
            StanjeRačuna += iznos;
        }
        public void Isplati(decimal iznos)
        {
            Console.WriteLine($"Korisnik {BrojRačuna} isplaćuje {iznos}");
            StanjeRačuna -= iznos;
        }
        public void PrikažiStanje()
        {
            Console.WriteLine($"{StanjeRačuna} eura");
        }
    }
}
