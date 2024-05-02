using PrvaDZedukos;

class Program
{
    static void Main(string[] args)
    {
       Banka pbz=new Banka();

        Korisnik korisnik1 = new Korisnik
        {
            Ime = "Luka",
            Prezime="Lukić",
            OIB=1717717,
            BrojRačuna=1,
            StanjeRačuna=1000
        };
        korisnik1.PrikažiStanje();

        Korisnik korisnik2 = new Korisnik
        {
            Ime = "Marko",
            Prezime = "Markić",
            OIB = 17177172,
            BrojRačuna = 2,
            StanjeRačuna = 1500
        };
        korisnik2.PrikažiStanje(); 

        pbz.DodajKorisnika(korisnik1);
        pbz.DodajKorisnika(korisnik2);

        Slanje slanje1 = new Slanje
        {
            Iznos=100,
            BrojRačunaPošiljatelja=korisnik1.BrojRačuna,
            BrojRačunaPrimatelja=korisnik2.BrojRačuna
        };

        pbz.IzvršiTransakciju(slanje1);

        korisnik1.StanjeRačuna -= slanje1.Iznos;
        korisnik2.StanjeRačuna += slanje1.Iznos;


        korisnik1.PrikažiStanje();
        korisnik2.PrikažiStanje();

        korisnik1.Isplati(100);
        korisnik1.PrikažiStanje();

        korisnik2.Uplati(100);
        korisnik2.PrikažiStanje();
    }
}
