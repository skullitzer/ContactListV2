using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListV2.Business
{
    public abstract class Contact
    {
        private int _contactNumber;
        private string _name;
        private string _phoneNumber;
        private string _email;

        public int ContactNumber { get => _contactNumber; set => _contactNumber = value; }
        public string Name { get => _name; set => _name = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Email { get => _email; set => _email = value; }

        public Contact()
        {
            _contactNumber = 0;
            _name = "";
            _phoneNumber = "";
            _email = "";
        }

        public Contact(int initialContactNumber) : this()
        {
            _contactNumber = initialContactNumber;
        }

        public override string ToString()
        {
            return $"Contact Number: {_contactNumber}, Name: {_name}, Phone Number: {_phoneNumber}, Email: {_email}";
        }
    }
}
