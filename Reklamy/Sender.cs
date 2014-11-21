using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reklamy
{
    class Sender // MOCK
    {
        public bool WyslijMail(Mail mail)
        {
            if (mail.Mail.Contains("@"))
            {
                mail.EmailState = MailState.Wyslany;
                return true;
            }
            else
            {
                mail.EmailState = MailState.DoPonownegoWyslania;
                return false;
            }
        }
    }
}
