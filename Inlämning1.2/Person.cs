using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inlämning1._2
{
    public class Person
    {
        
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PostalNumber { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }

        public Person(string name, string address, string postalArea,
            string postalNumber, string phoneNumber, string mail)
        {
            FullName = name;
            Address = address;
            City = postalArea;
            PostalNumber = postalNumber;
            PhoneNumber = phoneNumber;
            Mail = mail;
        }

    }
}
       
    

