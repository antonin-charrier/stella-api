using Microsoft.EntityFrameworkCore;
using ourakoz.GaiaAPI.Models.Models.CardItem;

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
