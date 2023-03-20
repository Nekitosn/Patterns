using Observer.Enums;
using Observer.Interfaces;
using Observer.Models;

Console.WriteLine("\tStart program\n");

ICinema cinema = new Cinema();

IUser user1 = new User();
IUser user2 = new User();
IAdmin admin1 = new Admin();

cinema.Attach(admin1);
cinema.Attach(user1);
cinema.Attach(user2);

Console.WriteLine("\n\tThe notifies before users add the movie genres they are interested:");
cinema.SetGenreNextFilm(GenreFilm.Adventure);


Console.WriteLine("\n\tThe notifies after users add the movie genres they are interested:");
user1.AddGenre(GenreFilm.Adventure);
user1.AddGenre(GenreFilm.ScienceFiction);
user2.AddGenre(GenreFilm.Adventure);

Console.WriteLine("\n\tAdd first genre:");
cinema.SetGenreNextFilm(GenreFilm.Adventure);

Console.WriteLine("\n\tAdd second genre:");
cinema.SetGenreNextFilm(GenreFilm.ScienceFiction);


Console.WriteLine("\n\tUnsubscribe user from the genre:");
user2.RemoveGenre(GenreFilm.Adventure);

cinema.SetGenreNextFilm(GenreFilm.Adventure);


Console.WriteLine("\n\tEnd program");