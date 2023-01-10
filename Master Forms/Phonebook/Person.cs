using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Forms.Phonebook
{
    internal class Person
    {
        private string ID;
        private string firstName;
        private string lastName;
        private string cellphone;
        private string telephone;
        private string email;
        private string address;
        private string comment;

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cellphone { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }

    }
}
