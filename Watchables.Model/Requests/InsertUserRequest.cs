using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Watchables.Model.Requests
{
    public class InsertUserRequest : InsertAccountRequest
    {
        [EmailAddress]
        public string Mail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string ImageLink { get; set; }
        public bool Locked { get; set; }

    }
}
