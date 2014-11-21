using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reklamy
{
    class Osoba
    {
        public Osoba(string nazwa, string email)
        {
            Nazwa = nazwa;
            Email = email;
        }
        public string Nazwa { get; set; }
        public string Email { get; set; }
    }
}
