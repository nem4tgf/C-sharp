using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam
{
    public class ContactManager
{
    private Dictionary<string, Contact> contacts;

    public ContactManager()
    {
        contacts = new Dictionary<string, Contact>();
    }

    public void AddContact(string name, string phone)
    {
        if (contacts.ContainsKey(name))
        {
            Console.WriteLine($"Contact with name {name} already exists. Updating phone number.");
            contacts[name].Phone = phone;
        }
        else
        {
            contacts.Add(name, new Contact(name, phone));
        }
        Console.WriteLine($"Contact {name} added/updated successfully.");
    }

    public string FindContact(string name)
    {
        if (contacts.ContainsKey(name))
        {
            return contacts[name].Phone;
        }
        else
        {
            return "Not found";
        }
    }

    public void DisplayContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts found.");
        }
        else
        {
            Console.WriteLine("The Address Book");
            foreach (var contact in contacts.Values)
            {
                Console.WriteLine($"Name: {contact.Name}, Phone: {contact.Phone}");
            }
        }
    }
}
}