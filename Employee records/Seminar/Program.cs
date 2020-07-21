using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
            int unos;

            do
            {
                Console.WriteLine("Izbornik sa opcijama:");
                Console.WriteLine("\n 1:Dodavanje novog zaposlenika\n 2:Ažuriranje postojećeg zaposlenika\n 3:Prekidanje radnog odnosa zaposlenika\n 4:Ispis svih zaposlenika\n 5:Ispis aktivnih zaposlenika (zaposlenici koji su još uvijek u radnom odnosu)\n 6:Ispis zaposlenika s kojima je prekinut radni odnos\n 7:Prekid rada programa");

                int.TryParse(Console.ReadLine(), out unos);
                if (unos == 1) //dodavanje zaposlenika
                {
                    UnosZaposlenika(listaZaposlenika);
                }
                else if (unos == 2) //ažuriranje postojećeg zaposlenika
                {
                    if (listaZaposlenika.Count() == 0)
                    {
                        Console.WriteLine("Unos ne postoji");
                    }
                    else
                    {
                        Console.WriteLine("Kojeg zaposlenika želite ažurirati ");
                        IspisListe(listaZaposlenika);
                        int odabirZaposlenika = OdabirZaposlenika(listaZaposlenika);
                        AzuriranjeZaposlenika(listaZaposlenika, odabirZaposlenika);
                    }

                }
                else if (unos == 3) //prekid radnog odnosa zaposlenika
                {
                    int odabirZaposlenika;
                    IspisListe(listaZaposlenika);
                    odabirZaposlenika = OdabirZaposlenika(listaZaposlenika);
                    PrekidOdnosa(listaZaposlenika, odabirZaposlenika);

                }
                else if (unos == 4)//ispis zaposlenika
                {
                    IspisListe(listaZaposlenika);
                }
                else if (unos == 5) //ispis aktivnih zaposlenika
                {
                    AktivniZaposlenici(listaZaposlenika);
                }
                else if (unos == 6) //ispis zaposlenika sa prekinutim radnim odnosom
                {
                    NeaktivniZaposlenici(listaZaposlenika);
                }
                else if (unos == 7) //prekid programa
                {
                    Console.WriteLine("Prekid rada programa");
                }
            } while (unos !=7); //valid input check
        }
        public static void UnosZaposlenika( List<Zaposlenik> listaZaposlenika)
        {
            string ime;
            string prezime;
            string oib;
            string radnoMjesto;
            DateTime datum;
            do
            {
                Console.WriteLine("Ime zaposlenika: ");
                ime = Console.ReadLine();
            } while (ime == string.Empty);
            do
            {
                Console.WriteLine("Prezime zaposlenika: ");
                prezime = Console.ReadLine();
            } while (prezime == string.Empty);
            do
            {
                Console.WriteLine("OIB zaposlenika: ");
                oib = Console.ReadLine();
            } while (oib == string.Empty);
            do
            {
                Console.WriteLine("Radno mjesto zaposlenika: ");
                radnoMjesto = Console.ReadLine();
            } while (radnoMjesto == string.Empty);
            do
            {
                Console.WriteLine("Datum zaposlenja zaposlenika: ");
                DateTime.TryParse(Console.ReadLine(), out datum);
            } while (datum.CompareTo(DateTime.MinValue)==0);

            listaZaposlenika.Add(new Zaposlenik(ime, prezime, oib, radnoMjesto, datum));

            Console.WriteLine("Unesen je zaposlenik");
        }
        public static void IspisListe(List<Zaposlenik> listaZaposlenika)
        {
            for (int i = 0; i < listaZaposlenika.Count; i++)
            {
                Console.WriteLine("Ime i prezime zaposlenika: {0}. {1} {2} \t OIB: {3} \t Radno mjesto: {4} \t Datum zaposlenja: {5}", i + 1,
                            listaZaposlenika.ElementAt(i).GetIme(), listaZaposlenika.ElementAt(i).GetPrezime(), listaZaposlenika.ElementAt(i).GetOIB(),
                            listaZaposlenika.ElementAt(i).GetRadnoMjesto(), listaZaposlenika.ElementAt(i).GetDatumZaposlenja().ToShortDateString());
            }
        }
        public static int OdabirZaposlenika(List<Zaposlenik> listaZaposlenika)
        {
            int odabirZaposlenika;
            do
            {
                Console.WriteLine("Unesi broj zaposlenika za odabir");
                int.TryParse(Console.ReadLine(), out odabirZaposlenika);

                if (odabirZaposlenika < 1 || odabirZaposlenika > listaZaposlenika.Count) //valid input check, nema nultnog zaposlenika
                {
                    Console.WriteLine("Neispravan unos");
                }
            } while (odabirZaposlenika < 1 || odabirZaposlenika > listaZaposlenika.Count);
            return odabirZaposlenika;
        }
        public static void AzuriranjeZaposlenika(List<Zaposlenik> listaZaposlenika, int odabirZaposlenika)
        {

            Console.WriteLine("Unesi 1 za promjenu imena,\n 2 za promjenu prezimena,\n 3 za promjenu OIB-a,\n 4 za promjenu naziva radnog mjesta,\n 5 za promjenu datuma zaposlenja");
            int unosPromjene;
            int.TryParse(Console.ReadLine(), out unosPromjene);
           
            if (unosPromjene == 1)
            {
                string korisnikIme;
                do
                {
                    Console.WriteLine("Unesi promjenu imena: ");
                    korisnikIme = Console.ReadLine();
                    listaZaposlenika.ElementAt(odabirZaposlenika - 1).SetIme(korisnikIme);
                } while (korisnikIme == string.Empty);
            }
            else if (unosPromjene == 2)
            {
                string korisnikPrezime;
                do
                {
                    Console.WriteLine("Unesi promjenu prezimena: ");
                    korisnikPrezime = Console.ReadLine();
                    listaZaposlenika.ElementAt(odabirZaposlenika - 1).SetPrezime(korisnikPrezime);
                } while (korisnikPrezime == string.Empty);
            }
            else if (unosPromjene == 3)
            {
                string korisnikOib;
                do
                {
                    Console.WriteLine("Unesi promjenu OIB-a: ");
                    korisnikOib = Console.ReadLine();
                    listaZaposlenika.ElementAt(odabirZaposlenika - 1).SetOIB(korisnikOib);
                } while (korisnikOib == string.Empty);
            }
            else if (unosPromjene == 4)
            {
                string korisnikRadnoMjesto;
                do
                {
                    Console.WriteLine("Unesi promjenu radnog mjesta: ");
                    korisnikRadnoMjesto = Console.ReadLine();
                    listaZaposlenika.ElementAt(odabirZaposlenika - 1).SetRadnoMjesto(korisnikRadnoMjesto);
                } while (korisnikRadnoMjesto == string.Empty);
            }
            else if (unosPromjene == 5)
            {
                DateTime datumZaposlenja;
                do
                {
                    Console.WriteLine("Unesi promjenu datuma zaposlenja: ");
                    DateTime.TryParse(Console.ReadLine(), out datumZaposlenja);
                    listaZaposlenika.ElementAt(odabirZaposlenika - 1).SetDatumZaposlenja(datumZaposlenja);
                } while (datumZaposlenja.CompareTo(DateTime.MinValue) == 0);
            }
        }
        public static void PrekidOdnosa(List<Zaposlenik> listaZaposlenika, int odabirZaposlenika)
        {
            DateTime prekidZaposlenja;
            do
            {
                Console.WriteLine("Unesi datum prekida zaposlenja: ");
                
                DateTime.TryParse(Console.ReadLine(), out prekidZaposlenja);

                if (listaZaposlenika.ElementAt(odabirZaposlenika - 1).GetDatumZaposlenja().CompareTo(prekidZaposlenja) > 0)//nemože se dati tkaz prije zaposlenja
                {
                    Console.WriteLine("Unesen datum prije zaposlenja!");
                }
            } while (listaZaposlenika.ElementAt(odabirZaposlenika - 1).GetDatumZaposlenja().CompareTo(prekidZaposlenja) > 0);

            listaZaposlenika.ElementAt(odabirZaposlenika - 1).SetDatumPrekidaZaposlenja(prekidZaposlenja);
        }
        public static void AktivniZaposlenici(List<Zaposlenik> listaZaposlenika)
        {

            Console.WriteLine("Aktivni zaposlenici su: ");
            for (int i = 0; i < listaZaposlenika.Count; i++)
            {
                if (listaZaposlenika.ElementAt(i).GetDatumZaposlenja().CompareTo(DateTime.Now.Date) <= 0)//ako je datum zaposlenja manje ili jednak današnjem datumu
                {

                    if ((listaZaposlenika.ElementAt(i).GetDatumPrekidaZaposlenja()) == DateTime.MinValue)//pri stvaranju zaposlenika prekid se postavlja na minimalnu vrijednost (1.1.prvegodine.), njima jos nisamo dali otkaz
                    {
                        Console.WriteLine(listaZaposlenika.ElementAt(i).GetIme(), listaZaposlenika.ElementAt(i).GetPrezime(), listaZaposlenika.ElementAt(i).GetOIB(),
                                listaZaposlenika.ElementAt(i).GetRadnoMjesto(), listaZaposlenika.ElementAt(i).GetDatumZaposlenja());

                    }
                    else if (listaZaposlenika.ElementAt(i).GetDatumPrekidaZaposlenja().CompareTo(DateTime.Now.Date) >= 0)//datum prekida veći ili jednak dns, jos uvijek aktivan
                    {
                        Console.WriteLine(listaZaposlenika.ElementAt(i).GetIme(), listaZaposlenika.ElementAt(i).GetPrezime(), listaZaposlenika.ElementAt(i).GetOIB(),
                               listaZaposlenika.ElementAt(i).GetRadnoMjesto(), listaZaposlenika.ElementAt(i).GetDatumZaposlenja());
                    }
                }
            }
        }
        public static void NeaktivniZaposlenici(List<Zaposlenik> listaZaposlenika)
        {
            Console.WriteLine("Neaktivni zaposlenici su: ");
            for (int i = 0; i < listaZaposlenika.Count; i++)
            {
                if ((listaZaposlenika.ElementAt(i).GetDatumPrekidaZaposlenja()) != DateTime.MinValue) // svi zaposlenici prije nego se ažurira datum prekida (da otkaz)
                {
                    if (DateTime.Now.Date.CompareTo(listaZaposlenika.ElementAt(i).GetDatumPrekidaZaposlenja()) > 0) //ako je današnji datum veći/poslje od datuma prekida
                    {
                        Console.WriteLine(listaZaposlenika.ElementAt(i).GetIme(), listaZaposlenika.ElementAt(i).GetPrezime(), listaZaposlenika.ElementAt(i).GetOIB(),
                                listaZaposlenika.ElementAt(i).GetRadnoMjesto(), listaZaposlenika.ElementAt(i).GetDatumZaposlenja());

                    }
                }
            }
        }

    }
}
