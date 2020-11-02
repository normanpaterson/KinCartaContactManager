using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KinCartaContactManager.Models;
using KinCartaContactManager.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KinCartaContactManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController : ControllerBase
    {
        private ILogger _logger;
        private IContactSvc _service;


        public ContactsController(ILogger<ContactsController> logger, IContactSvc service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpPost("/api/contacts")]
        public ActionResult<Contact> GetContact(int ContactId)
        {
            return _service.GetContact(ContactId);
        }

        [HttpPost("/api/contacts/create")]
        public ActionResult<Contact> CreateContact(Contact NewContact)
        {
            _service.CreateContact(NewContact);
            return NewContact;
        }

        [HttpPut("/api/products/{id}")]
        public ActionResult<Contact> UpdateContact(Contact ContactToUpdate)
        {
            _service.UpdateContact(ContactToUpdate);
            return ContactToUpdate;
        }

        [HttpDelete("/api/products/{id}")]
        public ActionResult<int> DeleteContact(int id)
        {
            _service.DeleteContact(id);
            return id;
        }
    }
}
