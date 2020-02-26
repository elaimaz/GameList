using GameList.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;
using System.Linq;

namespace GameList.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GameListContext(serviceProvider.GetRequiredService<DbContextOptions<GameListContext>>()))
            {
                //Look for any games
                if (context.Game.Any())
                {
                    return; //DB has seeded
                }
               
                context.Game.AddRange(
                    new Game
                    {
                        Title = "The Legend of Zelda: Breath of the Wild",
                        Genre = "Action",
                        Plataform = "Nintendo Switch",
                        Developer = "Nintendo",
                        Publisher = "Nintendo",
                        ReleaseDate = DateTime.Parse("2017-03-03"),
                        Description = "No kingdom. No memories. After a 100-year slumber, Link wakes up alone in a world he no longer remembers. Now the legendary hero must explore a vast and dangerous land and regain his memories before Hyrule is lost forever.\\" +
                        "Armed only with what he can scavenge,Link sets out to find answers and the resources needed to survive.",
                        Image = "https://www.zelda.com/breath-of-the-wild/assets/media/wallpapers/desktop-1.jpg"
                    },

                    new Game
                    {
                        Title = "The Witcher 3: Wild Hunt",
                        Genre = "RPG",
                        Plataform = "Windows",
                        Developer = "CD Projekt Red",
                        Publisher = "CD Projekt Red",
                        ReleaseDate = DateTime.Parse("2015-05-19"),
                        Description = "Você é Geralt de Rívia, um mercenário exterminador de monstros. Ao seu dispor, você tem todas as ferramentas: espadas afiadas, misturas letais, bestas furtivas e magias de combate poderosas. Diante de você, há um continente infestado de monstros devastado pela guerra que pode ser explorado à vontade. Seu contrato atual? Rastrear o Filho da Profecia, uma arma viva que pode alterar a forma do mundo."
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
