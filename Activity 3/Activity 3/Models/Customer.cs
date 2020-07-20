using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Activity_3.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [Display(Name="Phone Number")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Customer(int iD, string name, int age, string phoneNumber, string email)
        {
            ID = iD;
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}