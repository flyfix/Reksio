using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reklamy
{
    class ScheduleReminder
    {
        List<Koncert> SzukajKoncertow(DateTime data)
        {
            List<Koncert> listaKoncertow = new List<Koncert>() 
            {
                new Koncert("Pink Floyd", new DateTime(2000,1,1),
                    new List<Osoba>() {new Osoba("Tomasz","Tomasz@Tomasz.pl")})

              
            };
            //MOCK

            return listaKoncertow;
            
        }
    }
}
