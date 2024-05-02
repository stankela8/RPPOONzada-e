using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvaDZedukos
{
    public class Banka
    {
        public List<Korisnik> korisnici;
        private List<Transakcija> transakcije;

        public Banka()
        {
            korisnici = new List<Korisnik>();
            transakcije = new List<Transakcija>();
        }
        public void DodajKorisnika(Korisnik korisnik)
        {
            korisnici.Add(korisnik);  
        }
        public void IzvršiTransakciju(Transakcija transakcija)
        {
            transakcija.IzvršiTransakciju();
            transakcije.Add(transakcija);
        }
    }
}
