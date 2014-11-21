using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reklamy
{
    class MailCreator
    {
        public Mail FormulaMaila(Osoba osoba, Koncert koncert)
        {
            string wygenerowanaTresc = GenerujTresc(osoba, koncert);
            return new Mail(wygenerowanaTresc, osoba.Email);
        }

        private string GenerujTresc(Osoba osoba, Koncert koncert)
        {
            return "Witaj, " +
                osoba.Nazwa +
                "Zapraszam na koncert " +
                koncert.Nazwa +
                " dnia " +
                koncert.Data;
        }
    }
}
