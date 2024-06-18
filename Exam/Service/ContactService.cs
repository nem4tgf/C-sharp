using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam.Model;
using MySql.Data.MySqlClient;

namespace Exam.Service
{
    public class ContactService : IContactService
    {
        private MySqlConnection connection;

        public ContactService()
        {
        }

        public ContactService(string connectionString){
        connection = new MySqlConnection(connectionString);
        }

        public void AddContact(Contact contact){
           connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Insert into addressbook(id,name,phone) values(@id,@name, @phone)";
            cmd.Parameters.AddWithValue("@id",contact.Id);
            cmd.Parameters.AddWithValue("@name",contact.Name);
            cmd.Parameters.AddWithValue("@phone",contact.Phone);
            cmd.ExecuteNonQuery();
            connection.Close();
            
        }
        public List<Contact> GetAllContacts(){
            connection.Open();
            string query ="SELECT * FROM addressbook ";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Contact> contacts = new List<Contact>();
            while (reader.Read()){
                contacts.Add(new Contact{Id = reader.GetInt32(0), Name = reader.GetString(1), Phone = reader.GetString(2)});
            }
            reader.Close();
            connection.Close();
            return contacts;
        }

        public Contact GetContactByName(string name){
            connection.Open();
            string query = "SELECT * FROM addressbook WHERE name=@Name";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Name", name);
            MySqlDataReader reader = cmd.ExecuteReader();
            Contact contact = null;
            if (reader.Read())
            {
               contact = new Contact {Id = reader.GetInt32(0), Name = reader.GetString(1), Phone = reader.GetString(2)};
            }
            reader.Close();
            connection.Close();
            return contact;
        }


    }
           
  }
    