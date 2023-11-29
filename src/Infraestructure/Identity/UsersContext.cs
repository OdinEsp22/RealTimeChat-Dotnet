using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Identity;

public class UsersContext : IdentityDbContext<User>
{

     public DbSet<User> AppUsers {get; set;}
      public UsersContext(DbContextOptions<UsersContext> options) 
    : base(options)
    { }
}