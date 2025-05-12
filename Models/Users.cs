using Microsoft.AspNetCore.Identity;

namespace AllForOne_Store.Models
{
    public class Users: IdentityUser
    {
        public string FullName { get; set; }
    }
}
