using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Market.Domain.Entities
{
    public class User : IdentityUser
    {
        public DateTime JoinDate { get; set; }
        public ICollection<Account> Accounts { get; set; }
        public ICollection<Category> Categories { get; set; } 
    }
}
