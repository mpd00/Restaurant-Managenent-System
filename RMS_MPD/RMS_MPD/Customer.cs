using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_MPD
{
    class Customer2
    {
        private string fullname;
        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }
        private string socialID;
        public string SocialID
        {
            get { return socialID; }
            set { socialID = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
