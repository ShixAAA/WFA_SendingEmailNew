using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SendingEmail.UsersClasses
{
    public class InfoMailRu : InfoEmail
    {
        public InfoMailRu(StringPair emailAdressTo, string subject, string body)
            : base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.mail.ru";
            EmailAdressFrom = new StringPair("maluish2005@mail.ru", "Шеховцов Иван Александрович");
            EmailPassword = "cV9CRAmRKTGe4Mbw4p4g";
            Port = -1;
        }
        
    }
}
