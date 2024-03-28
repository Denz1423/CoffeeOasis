using Microsoft.AspNetCore.Identity;

namespace server.Entities
{
    public class User : IdentityUser<int>
    {
        public UserAddress Address { get; set; }
    }
}