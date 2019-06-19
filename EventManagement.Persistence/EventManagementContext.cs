using Microsoft.EntityFrameworkCore;

namespace EventManagement.Persistence
{
    public class EventManagementContext : DbContext
    {
        public EventManagementContext(DbContextOptions<EventManagementContext> options)
        : base(options)
        { }

        //public DbSet<Event> Events { get; set; }
    }
}