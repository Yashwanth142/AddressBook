using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookDetails
    {
        private string fname;
        private string lname;
        private string addr;
        private string city;
        private string state;
        private string zip;
        private string phnumber;
        private string email;



        public AddressBookDetails(string fname, string lname, string addr, string city, string state, string zip, string phnumber, string email)
        {
            this.fname = fname;
            this.lname = lname;
            this.addr = addr;
            this.city = city;
            this.zip = zip;
            this.phnumber = phnumber;
            this.email = email;
        }
        public string Contacts()
        {

            return this.fname + " " + this.lname + " " + this.addr + " " + this.city + " " + this.state + " " + this.zip + " " + this.phnumber + " " + this.email;
        }
    }
}
