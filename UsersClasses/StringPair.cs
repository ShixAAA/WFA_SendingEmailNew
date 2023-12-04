using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SendingEmail.UsersClasses
{
    public class StringPair
    {
        private string _emailAdress { get; set; }
        private string _name { get; set; }

        public string EmailAdress 
        {
            get { return _emailAdress; }
            set 
            {
                _emailAdress = string.IsNullOrWhiteSpace(value) ?
                    throw new ArgumentNullException(nameof(_emailAdress)) : value;
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = string.IsNullOrWhiteSpace(value) ?
                    throw new ArgumentNullException(nameof(_name)) : value;
            }
        }

        public StringPair(string emailAdress, string name)
        {
            EmailAdress = emailAdress;
            Name = name;

        }

        
    }
}
