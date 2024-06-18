using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam;



public class Program
{
    public static void Main()
    {
        ContactManager manager = new ContactManager();

        while (true)
        {
            Console.WriteLine("\nContact Manager");
            Console.WriteLine("1. Add new contact");
            Console.WriteLine("2. Find a contact by name");
            Console.WriteLine("3. Display contacts");
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
                    manager.AddContact(name, phone);
                    break;

                case "2":
                    Console.Write("Enter name to find: ");
                    string nameToFind = Console.ReadLine();
                    string foundPhone = manager.FindContact(nameToFind);
                    if (foundPhone == "Not found")
                    {
                        Console.WriteLine("Not found");
                    }
                    else
                    {
                        Console.WriteLine($"Phone number of {nameToFind} is {foundPhone}");
                    }
                    break;

                case "3":
                    manager.DisplayContacts();
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
