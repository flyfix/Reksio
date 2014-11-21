using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reklamy
{
    class MailerModule
    {
        private MailCreator creator = new MailCreator();
        private Sender mailSender = new Sender();
        private List<Mail> mailList;
        private bool retVal = true;

        bool WysliMaile(List<Koncert> ListWysylkowa)
        {
            bool tempRetVal = true;

            foreach (var koncert in ListWysylkowa)
            {
               foreach(var osoba in koncert.Osoby)
               {
                    mailList.Add(creator.FormulaMaila(osoba, koncert));
               }
            }

            foreach (var mail in mailList)
            {
                mailSender.WyslijMail(mail);

                //ZROBIC ponowne wysylanie TODO
            }
            return true;
        }
    }
}
