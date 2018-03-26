using Microsoft.EntityFrameworkCore;

namespace ourakoz.GaiaAPI.Models
{
    public class CardContext : DbContext
    {
        public CardContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<CardItem> CardItems { get; set; }
    }
}
