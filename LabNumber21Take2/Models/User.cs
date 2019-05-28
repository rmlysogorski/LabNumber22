using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabNumber21Take2.Models
{
    public class User
    {
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private string password;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public User()
        {

        }

        public User(string _firstName, string _lastName, string _email, string _phoneNumber, string _password)
        {
            FirstName = _firstName;
            LastName = _lastName;
            Email = _email;
            PhoneNumber = _phoneNumber;
            Password = _password;
        }
    }
}