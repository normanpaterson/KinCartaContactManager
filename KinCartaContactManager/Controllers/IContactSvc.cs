using KinCartaContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinCartaContactManager.Services
{
    public interface IContactSvc
    {
        //•Create a contact record
        public Contact CreateContact(Contact NewContact);
        //• Retrieve a contact record
        public Contact GetContact(int ContactId);
        //• Update a contact record
        public Contact UpdateContact(Contact ContactToUpdate);
        //• Delete a contact record
        public int DeleteContact(int ContactId);
        //• Search for a record by email or phone number
        public List<Contact> FindConactByEmailOrPhone(string EmailOrPhone, string searchText);
        //• Retrieve all records from the same state or city
        public List<Contact> FindContactsByStateOrCity(string CityOrState, string searchText);
    }
}
