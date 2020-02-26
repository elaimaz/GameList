using Microsoft.EntityFrameworkCore;
using GameList.Models;

namespace GameList.Data
{
    public class GameListContext : DbContext
    {
        public GameListContext (DbContextOptions<GameListContext> options) : base(options)
        {
        }

        public DbSet<Game> Game { get; set; }
    }
}
