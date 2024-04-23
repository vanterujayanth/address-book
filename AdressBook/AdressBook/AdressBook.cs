using System;                          //using System. 
using System.Collections.Generic;   // using System.Collections.Generic;                                                                                                                                  
using System.Linq;                   //using System.Linq;
using System.Text;                  // using System.Text;
using System.Threading.Tasks;       // using System.Threading.Tasks;
using System.Xml.Linq;              // using System.Xml.Linq;

namespace AdressBook
{
    public  class PersionalDetails
    {
       
        public string FirstName {  get; set; }
        public string LastName {  get; set; }
        public string Address {  get; set; }
        public  string PhoneNumber {  get; set; }
        public  string City {  get; set; }
        public   string Country {  get; set; }
        public  string Zip {  get; set; }
        public  string Gmail {  get; set; }
        // this is a constroctor
        public PersionalDetails(string firstname,string lastname,string address,string phonenumber,string city,string country,string zip,string gmail)
        {
            FirstName = firstname; 
            LastName = lastname;
            Address = address;                      // here i am going to get all the details of the persion 
            PhoneNumber = phonenumber;
            City = city;
            Country = country;
            Zip = zip;
            Gmail = gmail;
        }
        
    }
}
