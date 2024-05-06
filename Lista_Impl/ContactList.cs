using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Impl
{
    internal class ContactList
    {
        Contact? head;
        Contact? tail;

        public ContactList()
        {
            head = null;
            tail = null;
        }

        public void Add(Contact contact)
        {
            if (IsEmpty())
            {
                this.head = contact;
                this.tail = contact;
            }
            else
            {
                int comparison = string.Compare(contact.getName(), head.getName(), comparisonType: StringComparison.OrdinalIgnoreCase);

                if (comparison <= 0)
                {
                    Contact aux = head;
                    head = contact;
                    head.setNext(aux);
                }
                else
                {
                    Contact aux = head;
                    Contact prev = head;
                    do
                    {
                        comparison = string.Compare(contact.getName(), aux.getName(), comparisonType: StringComparison.OrdinalIgnoreCase);
                        if (comparison > 0)
                        {
                            prev = aux;
                            aux = aux.getNext();
                        }
                    } while (comparison > 0 && aux != null);

                    prev.setNext(contact);
                    contact.setNext(aux);

                    if(aux == null)
                    {
                        tail = contact;
                    }
                }
            }
        }

        private bool IsEmpty()
        {
            return head == null && tail == null;
        }
    }
}
