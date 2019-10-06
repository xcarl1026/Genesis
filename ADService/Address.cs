using System;
using System.Collections.Generic;
using System.Text;

namespace ADService
{
    class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string[] State { get; set; }
        public string Zip { get; set; }
        public string[] Country { get; set; }
    }
}
