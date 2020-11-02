using System;
using System.ComponentModel.DataAnnotations;

namespace KinCartaContactManager.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; } 
        public string HouseName { get; set; }
        public string City { get; set; }
        public double PinCode { get; set; }
    }
}