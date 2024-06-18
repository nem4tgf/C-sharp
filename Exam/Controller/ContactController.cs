using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam.Service;
using Exam.Model;

namespace Exam.Controller
{
    public class ContactController
    {
        //Instante of model
        private IContactService contactService;
        public ContactController(IContactService conService){
            contactService = conService;
        }

        public void AddContact(Contact contact){
            contactService.AddContact(contact);
        }

        public Contact GetContactByName(string name){
            return contactService.GetContactByName(name);
        }
        
        public List<Contact> GetAllContacts(){
           return contactService.GetAllContacts();
        }
    }
}