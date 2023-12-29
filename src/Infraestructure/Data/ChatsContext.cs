using Core.Entities.MessageAgregate;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data;
public class ChatsContext : DbContext
{
    public DbSet<Message> Messages {get; set;}

    public ChatsContext(DbContextOptions<ChatsContext> options) 
    : base(options)
    { }
}