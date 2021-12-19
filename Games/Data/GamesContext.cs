#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Games.Models;

namespace Games.Data
{
    public class GamesContext : DbContext
    {
        public GamesContext (DbContextOptions<GamesContext> options)
            : base(options)
        {
        }

        public DbSet<Games.Models.Game> Game { get; set; }
    }
}
