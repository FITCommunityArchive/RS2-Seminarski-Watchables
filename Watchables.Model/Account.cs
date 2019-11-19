using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public Role Role { get; set; }
    }
}

public enum Role
{
    Korisnik,
    Admin
}