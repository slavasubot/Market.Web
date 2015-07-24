using System;

namespace Market.Domain.Entities
{
   public class Account
    {
        public int Id { get; set; }      
        public string Descriptions { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
       

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
