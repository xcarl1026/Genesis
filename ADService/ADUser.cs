using System;

namespace ADService
{
    public class ADUser
    {
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string Intials { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string Office { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public ADUser()
        {

        }
    }
}
