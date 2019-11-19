using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class Users
    {
        public Users()
        {
            Orders = new HashSet<Orders>();
            UsersMovies = new HashSet<UsersMovies>();
            UsersNotifications = new HashSet<UsersNotifications>();
            UsersRotations = new HashSet<UsersRotations>();
            UsersShows = new HashSet<UsersShows>();
            UsersSubscriptions = new HashSet<UsersSubscriptions>();
        }

        public int UserId { get; set; }
        public string Mail { get; set; }       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string ImageLink { get; set; }
        public bool Locked { get; set; }

        public int AccountId { get; set; }
        public virtual Account Account { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<UsersMovies> UsersMovies { get; set; }
        public virtual ICollection<UsersNotifications> UsersNotifications { get; set; }
        public virtual ICollection<UsersRotations> UsersRotations { get; set; }
        public virtual ICollection<UsersShows> UsersShows { get; set; }
        public virtual ICollection<UsersSubscriptions> UsersSubscriptions { get; set; }
    }
}
