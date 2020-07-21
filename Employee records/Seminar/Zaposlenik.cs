using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{
    class Zaposlenik
    {
        private string ime;
        private string prezime;
        private string OIB;
        private string nazivRadnogMjesta;
        private DateTime datumZaposlenja;
        private DateTime datumPrekidaZaposlenja; 

        public Zaposlenik(string ime, string prezime, string oib, string nazivRadnogMjesta, DateTime datumZaposlenja)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.OIB = oib;
            this.nazivRadnogMjesta = nazivRadnogMjesta;
            this.datumZaposlenja = datumZaposlenja;
        }



        public string GetIme()
        {
            return this.ime;
        }
        public void SetIme(string ime)
        {
            this.ime = ime;
        }
        public string GetPrezime()
        {
            return this.prezime;
        }
        public void SetPrezime(string prezime)
        {
            this.prezime = prezime;
        }
        public string GetOIB()
        {
            return this.OIB;
        }
        public void SetOIB(string oib)
        {
            this.OIB = oib;
        }
        public string GetRadnoMjesto()
        {
            return this.nazivRadnogMjesta;
        }
        public void SetRadnoMjesto(string radnoMjesto)
        {
            this.nazivRadnogMjesta = radnoMjesto;
        }
        public DateTime GetDatumZaposlenja()
        {
            return this.datumZaposlenja;
        }
        public void SetDatumZaposlenja(DateTime datumZaposlenja)
        {
            this.datumZaposlenja = datumZaposlenja;
        }
        public DateTime GetDatumPrekidaZaposlenja()
        {
            return this.datumPrekidaZaposlenja;
        }
        public void SetDatumPrekidaZaposlenja(DateTime prekidZaposlenja)
        {
            this.datumPrekidaZaposlenja = prekidZaposlenja;
        }

    }
}
