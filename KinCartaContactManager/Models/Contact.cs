using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KinCartaContactManager.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int AddressID { get; set; }
        public Address Address { get; set; }
        public byte[] ContactImage { get; set; }
    }
}
