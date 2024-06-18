using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam;
using Exam.Controller;
using Exam.Model;
using Exam.Service;



public class Program
{
    static string connectionString ="Server=127.0.0.1;Database=addBook;User Id=root;Password=;";
    public static void Main()
    {
        
        ContactService contact = new ContactService();
        IContactService contactService = new ContactService(connectionString);
        ContactController contactController = new ContactController(contactService);

        while (true)
        {
            Console.WriteLine("\nContact Manager");
            Console.WriteLine("1. Add new contact");
            Console.WriteLine("2. Display contacts");
            Console.WriteLine("3. Find a contact by name");
            Console.WriteLine("4. Exit");
            
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter phone: ");
                    string phone = Console.ReadLine();
                    Contact newcontact = new Contact{Name = name, Phone = phone};
                    contactController.AddContact(newcontact);
                    break;

                case "2":
                    contactController.GetAllContacts();
                    break;

                case "3":
                    Console.Write("Enter name to find: ");
                    string findName = Console.ReadLine();
                    Contact findContact = contactController.GetContactByName(findName);
                    if (findContact != null)
                    {
                        Console.WriteLine("Not found");
                    }
                    else
                    {
                        Console.WriteLine($"Phone number of {findName} is {findContact}");
                    }
                    break;

                case "4":
                    Console.WriteLine("Exiting the application.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
