using Microsoft.EntityFrameworkCore;
using MovieWorld.Data;

// https://github.com/yigith/TopMovies/blob/master/TopMovies/Models/ApplicationDbContextSeed.cs
namespace MovieWorld
{
    public partial class Form1 : Form
    {
        ApplicationDbContext db = new();

        public Form1()
        {
            SeedData();
            InitializeComponent();
            ListGenres();
        }

        private void ListGenres()
        {
            // Eager Loading
            cboGenre.DataSource = db.Genres.Include(g => g.Movies).ToList();
        }

        private void SeedData()
        {
            if (db.Genres.Any() || db.Movies.Any())
                return;

            var action = new Genre() { Name = "Action" };
            var adventure = new Genre() { Name = "Adventure" };
            var animation = new Genre() { Name = "Animation" };
            var biography = new Genre() { Name = "Biography" };
            var comedy = new Genre() { Name = "Comedy" };
            var crime = new Genre() { Name = "Crime" };
            var drama = new Genre() { Name = "Drama" };
            var family = new Genre() { Name = "Family" };
            var fantasy = new Genre() { Name = "Fantasy" };
            var filmNoir = new Genre() { Name = "Film-Noir" };
            var history = new Genre() { Name = "History" };
            var horror = new Genre() { Name = "Horror" };
            var music = new Genre() { Name = "Music" };
            var musical = new Genre() { Name = "Musical" };
            var mystery = new Genre() { Name = "Mystery" };
            var romance = new Genre() { Name = "Romance" };
            var sciFi = new Genre() { Name = "Sci-Fi" };
            var thriller = new Genre() { Name = "Thriller" };
            var war = new Genre() { Name = "War" };
            var western = new Genre() { Name = "Western" };

            var genres = new Genre[] { action, adventure, animation, biography, comedy, crime, drama, family, fantasy, filmNoir, history, horror, music, musical, mystery, romance, sciFi, thriller, war, western };

            db.AddRange(genres);

            var movies = new Movie[]
{
                new Movie()
                {
                    Title = "The Shawshank Redemption",
                    Year = 1994,
                    Rating = 9.3m,
                    Genres = new List<Genre>() { drama }
                },
                new Movie()
                {
                    Title = "The Godfather",
                    Year = 1972,
                    Rating = 9.2m,
                    Genres = new List<Genre>() { crime, drama }
                },
                new Movie()
                {
                    Title = "The Dark Knight",
                    Year = 2008,
                    Rating = 9m,
                    Genres = new List<Genre>() { action, crime, drama }
                },
                new Movie()
                {
                    Title = "The Lord of the Rings: The Return of the King",
                    Year = 2003,
                    Rating = 9m,
                    Genres = new List<Genre>() { action, adventure, drama }
                },
                new Movie()
                {
                    Title = "Schindler's List",
                    Year = 1993,
                    Rating = 9m,
                    Genres = new List<Genre>() { biography, drama, history }
                },
                new Movie()
                {
                    Title = "The Godfather: Part II",
                    Year = 1974,
                    Rating = 9m,
                    Genres = new List<Genre>() { crime, drama }
                },
                new Movie()
                {
                    Title = "12 Angry Men",
                    Year = 1957,
                    Rating = 9m,
                    Genres = new List<Genre>() { crime, drama }
                },
                new Movie()
                {
                    Title = "Pulp Fiction",
                    Year = 1994,
                    Rating = 8.9m,
                    Genres = new List<Genre>() { crime, drama }
                },
                new Movie()
                {
                    Title = "Everything Everywhere All at Once",
                    Year = 2022,
                    Rating = 8.8m,
                    Genres = new List<Genre>() { action, adventure, comedy }
                },
                new Movie()
                {
                    Title = "Inception",
                    Year = 2010,
                    Rating = 8.8m,
                    Genres = new List<Genre>() { action, adventure, sciFi }
                },
                new Movie()
                {
                    Title = "The Lord of the Rings: The Two Towers",
                    Year = 2002,
                    Rating = 8.8m,
                    Genres = new List<Genre>() { action, adventure, drama }
                },
                new Movie()
                {
                    Title = "Fight Club",
                    Year = 1999,
                    Rating = 8.8m,
                    Genres = new List<Genre>() { drama }
                },
                new Movie()
                {
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    Year = 2001,
                    Rating = 8.8m,
                    Genres = new List<Genre>() { action, adventure, drama }
                },
                new Movie()
                {
                    Title = "Forrest Gump",
                    Year = 1994,
                    Rating = 8.8m,
                    Genres = new List<Genre>() { drama, romance }
                },
                new Movie()
                {
                    Title = "The Good, the Bad and the Ugly",
                    Year = 1966,
                    Rating = 8.8m,
                    Genres = new List<Genre>() { adventure, western }
                },
                new Movie()
                {
                    Title = "The Matrix",
                    Year = 1999,
                    Rating = 8.7m,
                    Genres = new List<Genre>() { action, sciFi }
                },
                new Movie()
                {
                    Title = "Goodfellas",
                    Year = 1990,
                    Rating = 8.7m,
                    Genres = new List<Genre>() { biography, crime, drama }
                },
                new Movie()
                {
                    Title = "Star Wars: Episode V - The Empire Strikes Back",
                    Year = 1980,
                    Rating = 8.7m,
                    Genres = new List<Genre>() { action, adventure, fantasy }
                },
                new Movie()
                {
                    Title = "One Flew Over the Cuckoo's Nest",
                    Year = 1975,
                    Rating = 8.7m,
                    Genres = new List<Genre>() { drama }
                },
                new Movie()
                {
                    Title = "Interstellar",
                    Year = 2014,
                    Rating = 8.6m,
                    Genres = new List<Genre>() { adventure, drama, sciFi }
                },
                new Movie()
                {
                    Title = "City of God",
                    Year = 2002,
                    Rating = 8.6m,
                    Genres = new List<Genre>() { crime, drama }
                },
                new Movie()
                {
                    Title = "Spirited Away",
                    Year = 2001,
                    Rating = 8.6m,
                    Genres = new List<Genre>() { animation, adventure, family }
                },
                new Movie()
                {
                    Title = "Saving Private Ryan",
                    Year = 1998,
                    Rating = 8.6m,
                    Genres = new List<Genre>() { drama, war }
                },
                new Movie()
                {
                    Title = "The Green Mile",
                    Year = 1999,
                    Rating = 8.6m,
                    Genres = new List<Genre>() { crime, drama, fantasy }
                },
                new Movie()
                {
                    Title = "Life Is Beautiful",
                    Year = 1997,
                    Rating = 8.6m,
                    Genres = new List<Genre>() { comedy, drama, romance }
                },
                new Movie()
                {
                    Title = "Se7en",
                    Year = 1995,
                    Rating = 8.6m,
                    Genres = new List<Genre>() { crime, drama, mystery }
                },
                new Movie()
                {
                    Title = "Terminator 2: Judgment Day",
                    Year = 1991,
                    Rating = 8.6m,
                    Genres = new List<Genre>() { action, sciFi }
                },
                new Movie()
                {
                    Title = "The Silence of the Lambs",
                    Year = 1991,
                    Rating = 8.6m,
                    Genres = new List<Genre>() { crime, drama, thriller }
                },
                new Movie()
                {
                    Title = "Star Wars",
                    Year = 1977,
                    Rating = 8.6m,
                    Genres = new List<Genre>() { action, adventure, fantasy }
                },
                new Movie()
                {
                    Title = "Hara-Kiri",
                    Year = 1962,
                    Rating = 8.6m,
                    Genres = new List<Genre>() { action, drama, mystery }
                },
                new Movie()
                {
                    Title = "Seven Samurai",
                    Year = 1954,
                    Rating = 8.6m,
                    Genres = new List<Genre>() { action, drama }
                },
                new Movie()
                {
                    Title = "It's a Wonderful Life",
                    Year = 1946,
                    Rating = 8.6m,
                    Genres = new List<Genre>() { drama, family, fantasy }
                },
                new Movie()
                {
                    Title = "Parasite",
                    Year = 2019,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { comedy, drama, thriller }
                },
                new Movie()
                {
                    Title = "Whiplash",
                    Year = 2014,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { drama, music }
                },
                new Movie()
                {
                    Title = "The Intouchables",
                    Year = 2011,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { biography, comedy, drama }
                },
                new Movie()
                {
                    Title = "The Prestige",
                    Year = 2006,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { drama, mystery, thriller }
                },
                new Movie()
                {
                    Title = "The Departed",
                    Year = 2006,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { crime, drama, thriller }
                },
                new Movie()
                {
                    Title = "The Pianist",
                    Year = 2002,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { biography, drama, music }
                },
                new Movie()
                {
                    Title = "Gladiator",
                    Year = 2000,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { action, adventure, drama }
                },
                new Movie()
                {
                    Title = "American History X",
                    Year = 1998,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { drama }
                },
                new Movie()
                {
                    Title = "The Usual Suspects",
                    Year = 1995,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { crime, drama, mystery }
                },
                new Movie()
                {
                    Title = "Léon: The Professional",
                    Year = 1994,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { action, crime, drama }
                },
                new Movie()
                {
                    Title = "The Lion King",
                    Year = 1994,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { animation, adventure, drama }
                },
                new Movie()
                {
                    Title = "Cinema Paradiso",
                    Year = 1988,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { drama, romance }
                },
                new Movie()
                {
                    Title = "Grave of the Fireflies",
                    Year = 1988,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { animation, drama, war }
                },
                new Movie()
                {
                    Title = "Back to the Future",
                    Year = 1985,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { adventure, comedy, sciFi }
                },
                new Movie()
                {
                    Title = "Apocalypse Now",
                    Year = 1979,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { drama, mystery, war }
                },
                new Movie()
                {
                    Title = "Alien",
                    Year = 1979,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { horror, sciFi }
                },
                new Movie()
                {
                    Title = "Once Upon a Time in the West",
                    Year = 1968,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { western }
                },
                new Movie()
                {
                    Title = "Psycho",
                    Year = 1960,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { horror, mystery, thriller }
                },
                new Movie()
                {
                    Title = "Rear Window",
                    Year = 1954,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { mystery, thriller }
                },
                new Movie()
                {
                    Title = "Casablanca",
                    Year = 1942,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { drama, romance, war }
                },
                new Movie()
                {
                    Title = "Modern Times",
                    Year = 1936,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { comedy, drama, romance }
                },
                new Movie()
                {
                    Title = "City Lights",
                    Year = 1931,
                    Rating = 8.5m,
                    Genres = new List<Genre>() { comedy, drama, romance }
                },
                new Movie()
                {
                    Title = "Capernaum",
                    Year = 2018,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { drama }
                },
                new Movie()
                {
                    Title = "Joker",
                    Year = 2019,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { crime, drama, thriller }
                },
                new Movie()
                {
                    Title = "Your Name.",
                    Year = 2016,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { animation, drama, fantasy }
                },
                new Movie()
                {
                    Title = "Spider-Man: Into the Spider-Verse",
                    Year = 2018,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { animation, action, adventure }
                },
                new Movie()
                {
                    Title = "Avengers: Endgame",
                    Year = 2019,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { action, adventure, drama }
                },
                new Movie()
                {
                    Title = "Avengers: Infinity War",
                    Year = 2018,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { action, adventure, sciFi }
                },
                new Movie()
                {
                    Title = "Coco",
                    Year = 2017,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { animation, adventure, comedy }
                },
                new Movie()
                {
                    Title = "Django Unchained",
                    Year = 2012,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { drama, western }
                },
                new Movie()
                {
                    Title = "The Dark Knight Rises",
                    Year = 2012,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { action, crime, drama }
                },
                new Movie()
                {
                    Title = "3 Idiots",
                    Year = 2009,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { comedy, drama }
                },
                new Movie()
                {
                    Title = "WALL·E",
                    Year = 2008,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { animation, adventure, family }
                },
                new Movie()
                {
                    Title = "The Lives of Others",
                    Year = 2006,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { drama, mystery, thriller }
                },
                new Movie()
                {
                    Title = "Oldboy",
                    Year = 2003,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { action, drama, mystery }
                },
                new Movie()
                {
                    Title = "Memento",
                    Year = 2000,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { mystery, thriller }
                },
                new Movie()
                {
                    Title = "American Beauty",
                    Year = 1999,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { drama }
                },
                new Movie()
                {
                    Title = "Princess Mononoke",
                    Year = 1997,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { animation, action, adventure }
                },
                new Movie()
                {
                    Title = "Braveheart",
                    Year = 1995,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { biography, drama, history }
                },
                new Movie()
                {
                    Title = "Aliens",
                    Year = 1986,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { action, adventure, sciFi }
                },
                new Movie()
                {
                    Title = "Amadeus",
                    Year = 1984,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { biography, drama, music }
                },
                new Movie()
                {
                    Title = "Indiana Jones and the Raiders of the Lost Ark",
                    Year = 1981,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { action, adventure }
                },
                new Movie()
                {
                    Title = "The Boat",
                    Year = 1981,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { drama, war }
                },
                new Movie()
                {
                    Title = "The Shining",
                    Year = 1980,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { drama, horror }
                },
                new Movie()
                {
                    Title = "High and Low",
                    Year = 1963,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { crime, drama, mystery }
                },
                new Movie()
                {
                    Title = "Dr. Strangelove or: How I Learned to Stop Worrying and Love the Bomb",
                    Year = 1964,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { comedy, war }
                },
                new Movie()
                {
                    Title = "Witness for the Prosecution",
                    Year = 1957,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { crime, drama, mystery }
                },
                new Movie()
                {
                    Title = "Paths of Glory",
                    Year = 1957,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { drama, war }
                },
                new Movie()
                {
                    Title = "Sunset Blvd.",
                    Year = 1950,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { drama, filmNoir }
                },
                new Movie()
                {
                    Title = "The Great Dictator",
                    Year = 1940,
                    Rating = 8.4m,
                    Genres = new List<Genre>() { comedy, drama, war }
                },
                new Movie()
                {
                    Title = "The Hunt",
                    Year = 2012,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { drama }
                },
                new Movie()
                {
                    Title = "Toy Story 3",
                    Year = 2010,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { animation, adventure, comedy }
                },
                new Movie()
                {
                    Title = "Inglourious Basterds",
                    Year = 2009,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { adventure, drama, war }
                },
                new Movie()
                {
                    Title = "Eternal Sunshine of the Spotless Mind",
                    Year = 2004,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { drama, romance, sciFi }
                },
                new Movie()
                {
                    Title = "Amélie",
                    Year = 2001,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { comedy, romance }
                },
                new Movie()
                {
                    Title = "Requiem for a Dream",
                    Year = 2000,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { drama }
                },
                new Movie()
                {
                    Title = "Good Will Hunting",
                    Year = 1997,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { drama, romance }
                },
                new Movie()
                {
                    Title = "Toy Story",
                    Year = 1995,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { animation, adventure, comedy }
                },
                new Movie()
                {
                    Title = "Reservoir Dogs",
                    Year = 1992,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { crime, drama, thriller }
                },
                new Movie()
                {
                    Title = "Once Upon a Time in America",
                    Year = 1984,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { crime, drama }
                },
                new Movie()
                {
                    Title = "Star Wars: Episode VI - Return of the Jedi",
                    Year = 1983,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { action, adventure, fantasy }
                },
                new Movie()
                {
                    Title = "2001: A Space Odyssey",
                    Year = 1968,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { adventure, sciFi }
                },
                new Movie()
                {
                    Title = "Lawrence of Arabia",
                    Year = 1962,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { adventure, biography, drama }
                },
                new Movie()
                {
                    Title = "North by Northwest",
                    Year = 1959,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { action, adventure, mystery }
                },
                new Movie()
                {
                    Title = "Vertigo",
                    Year = 1958,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { mystery, romance, thriller }
                },
                new Movie()
                {
                    Title = "Singin' in the Rain",
                    Year = 1952,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { comedy, musical, romance }
                },
                new Movie()
                {
                    Title = "Citizen Kane",
                    Year = 1941,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { drama, mystery }
                },
                new Movie()
                {
                    Title = "M",
                    Year = 1931,
                    Rating = 8.3m,
                    Genres = new List<Genre>() { crime, mystery, thriller }
                }
            };
            db.AddRange(movies);
            db.SaveChanges();
        }

        private void cboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGenre.SelectedIndex == -1)
            {
                dgvMovies.DataSource = null;
            }
            else
            {
                Genre genre = (Genre)cboGenre.SelectedItem;
                dgvMovies.DataSource = genre.Movies.Select(m => new
                {
                    m.Id,
                    m.Title,
                    m.Year,
                    m.Rating,
                    Genres = string.Join(", ", m.Genres.Select(g => g.Name))
                }).ToList();
            }
        }
    }
}