using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SendingEmail.UsersClasses
{
    public class InfoGMail : InfoEmail
    {
        public InfoGMail (StringPair emailAdressTo, string subject, string body) 
        : base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.gmail.com";
            EmailAdressFrom = new StringPair("cocsell1337@gmail.com", "Шеховцов Иван Александрович");
            EmailPassword = "nqyjeayhosbvcgye";
            Port = 587;
        }

    }
}
