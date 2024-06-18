using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam.Model;

namespace Exam.Service
{
    public interface IContactService
    {
        void AddContact(Contact contact);
        Contact GetContactByName(string name);
        List<Contact> GetAllContacts();
    }
}