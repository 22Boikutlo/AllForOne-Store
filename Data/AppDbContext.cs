using AllForOne_Store.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AllForOne_Store.Data
{
    public class AppDbContext: IdentityDbContext<Users>
    {
         public AppDbContext(DbContextOptions options) : base(options) 
        {
        }
    }
}
