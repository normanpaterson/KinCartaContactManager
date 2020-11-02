using KinCartaContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinCartaContactManager.Services
{
    public class ContactSvc : IContactSvc
    {
        private List<Contact> _contactItems;
        public ContactSvc()
        {
            _contactItems = new List<Contact>();
        }
        
        public Contact CreateContact(Contact NewContact)
        {
            _contactItems.Add(NewContact);
            return NewContact;
        }

        public int DeleteContact(int ContactId)
        {
            throw new NotImplementedException();
        }

        public List<Contact> FindConactByEmailOrPhone(string EmailOrPhone, string searchText)
        {
            List<Contact> returnvalue = new List<Contact>();
            if (EmailOrPhone == "Email")
            {
                returnvalue = _contactItems.Where(m => m.Email == searchText).ToList();
            }
            else if (EmailOrPhone == "Phone")
            {
                returnvalue = _contactItems.Where(m => m.PhoneNumber == searchText).ToList();
            }
            else
            {
                throw new Exception("Invalid EmailOrPhone parameter provided.");
            }
            return returnvalue;
        }

        public List<Contact> FindContactsByStateOrCity(string CityOrState, string searchText)
        {
            throw new NotImplementedException();
        }

        public Contact GetContact(int ContactId)
        {
            var returnvalue = _contactItems.Where(m => m.ID == ContactId).FirstOrDefault();
            return returnvalue;
        }

        public Contact UpdateContact(Contact ContactToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
