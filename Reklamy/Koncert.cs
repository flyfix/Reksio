using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reklamy
{
    class Koncert
    {

        public Koncert(string nazwa, DateTime data, List<Osoba> osoby)
        {
            Nazwa = nazwa;
            Data = data;
            Osoby = osoby;
        }
        public string Nazwa { get; set; }
        public DateTime Data { get; set; }
        public List<Osoba> Osoby { get; set; }
    }
}
