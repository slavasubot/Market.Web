using Market.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Market.Data.Contexts
{
    public class AuthContext : IdentityDbContext<User>
    {
        public AuthContext() : base("AuthContext")
        {
            
        }

        public static AuthContext Create()
        {
            return new AuthContext();
        }
    }
}
