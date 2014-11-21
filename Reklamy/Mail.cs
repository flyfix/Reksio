using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reklamy
{
    public enum MailState
    {
        PrzedWyslanie,
        DoPonownegoWyslania,
        PoPonownejProbie,
        Wyslany
    };

    class Mail
    {


        public MailState EmailState { get; set; }
        public Mail(string cTresc, string cMail)
        {
            this.EmailState = MailState.PrzedWyslanie;
            this.Tresc = cTresc;
            this.Mail = cMail;
        }

        public string Tresc { get; set; }
        public string Mail { get; set; }
        
    }
}
