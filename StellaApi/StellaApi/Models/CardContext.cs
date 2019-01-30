using Microsoft.EntityFrameworkCore;
using ourakoz.StellaApi.Models.Models.CardItem;

namespace ourakoz.StellaApi.Models
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
