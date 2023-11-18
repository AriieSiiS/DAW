using AUT03_02.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace AUT03_02.Seeders
{
    public class Seeder
    {
        public static void MainSeeder(ModelBuilder modelBuilder) 
        {
            List<Genre> genresList = GenreSeeder();
            modelBuilder.Entity<Genre>().HasData(genresList);

            List<Game> gamesList = GameSeeder(genresList);
            modelBuilder.Entity<Game>().HasData(gamesList);

        }

        public static List<Genre> GenreSeeder()
        {
            List<Genre> genreList = new List<Genre>
            {
            new Genre { Id = 1, Name = "Acción"},
            new Genre { Id = 2, Name = "Aventuras"},
            new Genre { Id = 3, Name = "RPG"}
            };
            return genreList;
        }
        public static List<Game> GameSeeder(List<Genre> genresList)
        {
            List<Game> gamesList = new List<Game>
            {
                new Game { Id = 1, Name = "The Last of Us", GenreId = 1},
                new Game { Id = 2, Name = "God of War", GenreId = 1},
                new Game { Id = 3, Name = "Zelda", GenreId = 2},
                new Game { Id = 4, Name = "Uncharted 4", GenreId = 2},
                new Game { Id = 5, Name = "The Witcher 3", GenreId = 3},
                new Game { Id = 6,Name = "Elder Scrolls", GenreId = 3}
            };

            return gamesList;
        }
    }
}
