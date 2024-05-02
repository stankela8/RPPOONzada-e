using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvaDZedukos
{
    public class Slanje : Transakcija
    {
        public int BrojRačunaPošiljatelja { get; set; }
        public int BrojRačunaPrimatelja { get; set; }

        public override void IzvršiTransakciju()
        {
            Console.WriteLine($"Korisnik {BrojRačunaPošiljatelja} šalje {Iznos} eura korisniku {BrojRačunaPrimatelja}");
            
        }
    }
}
