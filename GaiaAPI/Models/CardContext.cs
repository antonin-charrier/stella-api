using Microsoft.EntityFrameworkCore;

namespace GaiaAPI.Models
{
    public class CardContext : DbContext
    {
        public CardContext(DbContextOptions<CardContext> options)
            : base(options)
        {
        }

        public DbSet<CardItem> CardItems { get; set; }
    }
}
