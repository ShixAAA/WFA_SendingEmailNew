using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SendingEmail.UsersClasses
{

    public abstract class InfoEmail
    {
       private string _smtpClientAdress;
       private StringPair _emailAddressFrom;
       private string _emailPassword;
       private StringPair _emailAddressTo;
       private string _subject;
       private string _body;
       private int _port;

        public string SmtpClientAdress 
       {
            get { return _smtpClientAdress; }
            set 
            {
                _smtpClientAdress = String.IsNullOrWhiteSpace(value) ?
                throw new ArgumentNullException(nameof(_smtpClientAdress)) : value;
            }
       }

        public StringPair EmailAdressFrom
        {
            get { return _emailAddressFrom; }
            set
            {
                _emailAddressFrom = value ??
                throw new ArgumentNullException(nameof(_emailAddressFrom));
            }
        }

        public string EmailPassword
        {
            get { return _emailPassword; }
            set
            {
                _emailPassword = String.IsNullOrWhiteSpace(value) ?
                throw new ArgumentNullException(nameof(_emailPassword)) : value;
            }
        }

        public StringPair EmailAdressTo
        {
            get { return _emailAddressTo; }
            set
            {
                _emailAddressTo = value ??
                throw new ArgumentNullException(nameof(_emailAddressTo));
            }
        }

        public string Subject
        {
            get { return _subject; }
            set
            {
                _subject = String.IsNullOrWhiteSpace(value) ?
                    throw new ArgumentNullException(nameof(_subject)) :
                    value;
            }
        }

        public string Body
        {
            get { return _body; }
            set
            {
                _body = String.IsNullOrWhiteSpace(value) ?
                    throw new ArgumentNullException(nameof(value)) :
                    value;
            }
        }

        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        protected InfoEmail(StringPair emailAdressTo, string subject, string body)
        {
            EmailAdressTo = emailAdressTo;
            Subject = subject;
            Body = body;
        }
    }
}
