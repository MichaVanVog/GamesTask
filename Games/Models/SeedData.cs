using Games.Data;
using Microsoft.EntityFrameworkCore;

namespace Games.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new GamesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GamesContext>>());
            if (context.Game.Any())
            {
                return;
            }

            context.Game.AddRange(
                new Game
                {
                    Title = "FIFA 21",
                    DevelopersStudio = "EA SPORTS",
                    Genre = "Спорт"
                },

            new Game
            {
                Title = "Призрак Цусимы Day One Edition",
                DevelopersStudio = "неизвестно",
                Genre = "Экшен"
            },

            new Game
            {
                Title = "Одни из нас: Часть II",
                DevelopersStudio = "неизвестно",
                Genre = "Экшен"
            },

            new Game
            {
                Title = "Resident Evil: Village",
                DevelopersStudio = "Capcom",
                Genre = "Экшен"
            }
            );
            context.SaveChanges();
        }
    }
}
