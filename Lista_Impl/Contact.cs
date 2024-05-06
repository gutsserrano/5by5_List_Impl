using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Impl
{
    internal class Contact
    {
        string name;
        string phone;

        Contact? next;

        public Contact(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
            next = null;
        }

        public string getName()
        {
            return name;
        }

        public void setNext(Contact next)
        {
            this.next = next;
        }

        public Contact getNext()
        {
            return this.next;
        }
    }
}
