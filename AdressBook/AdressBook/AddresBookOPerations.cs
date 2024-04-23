using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdressBook
{
    public class AddresBookOPerations
    {
        public List<PersionalDetails> persionalDetails = new List<PersionalDetails>();
        // for adding the details of a persion int data base 
        public void AddContact(PersionalDetails details)
        {
            persionalDetails.Add(details);
        }
        // for seeing the detaials of the members who entered in the databas 
        public void Show()
        {
           
            foreach (PersionalDetails item in persionalDetails)
            {
                Console.WriteLine($"Name: {item.FirstName} {item.LastName}," +
                    $" Phone: {item.PhoneNumber} , Address :{item.Address} ," +
                    $" Email:{item.Gmail},City");
            }

        }
        // to find a person details on the basis of the first name and last name;
        public  PersionalDetails FindThePerson(string firstName, string lastName)
        {
            foreach (var contact in persionalDetails)
            {
                if ((contact.FirstName == firstName) && (contact.LastName == lastName))
                {
                    return contact;
                }
            }
            return null;
        }
        // to find the specific index is present in the details or not 
        public PersionalDetails FindTheIndex(string firstName, string lastName)
        {
            for (int j = 0;j <= persionalDetails.Count;j++)
            {
                if((firstName == persionalDetails[j].FirstName)&& (lastName == persionalDetails[j].LastName))
                {
                    return persionalDetails[j];
                }
            }
            return null;
        }
        // to delite a perticular persion detsils from the list 
        public PersionalDetails DeliteTheIndex(string fisrname,string lastname)
        {
            PersionalDetails existingContact = FindThePerson(fisrname,lastname);
            if (existingContact != null)
            {
                persionalDetails.Remove(existingContact);
                Console.WriteLine($"Contact {existingContact.FirstName} " +
                    $"{existingContact.LastName} deleted successfully.");
            }
            else
            {
                Console.WriteLine("Details is not found :");
            }
            return null;
        }
        // to edit the details of the person  if he is present 
        public void EditDEtails(string firstName, string lastName)
        {
            PersionalDetails existingContact = FindThePerson(firstName, lastName);

            if (existingContact != null)
            {
                Console.WriteLine($"Editing contact: {existingContact.FirstName} {existingContact.LastName}");

                Console.WriteLine("Enter new Firstname");
                existingContact.FirstName = Console.ReadLine();

                Console.WriteLine("Enter new last name");
                existingContact.LastName = Console.ReadLine();

                Console.WriteLine("Enter new address");
                existingContact.Address = Console.ReadLine();

                Console.WriteLine("Enter new city name");
                existingContact.City = Console.ReadLine();

                Console.WriteLine("Enter new zip code");
                existingContact.Zip = Console.ReadLine();

                Console.WriteLine("Enter new phone number");
                existingContact.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Enter new email id");
                existingContact.Gmail = Console.ReadLine();

                Console.WriteLine("Contact updated successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
       
    }
}
