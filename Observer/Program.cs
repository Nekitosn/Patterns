using Observer.Enums;
using Observer.Interfaces;
using Observer.Models;

Console.WriteLine("\tStart program\n");

ICinema cinema = new Cinema();

IUser userFirst = new User();
IUser userSecond = new User();
IAdmin admin = new Admin();

cinema.Attach(admin);
cinema.Attach(userFirst);
cinema.Attach(userSecond);

Console.WriteLine("\n\tThe notifies before users add the movie genres they are interested:");
cinema.SetGenre(FilmGenre.Adventure);


Console.WriteLine("\n\tThe notifies after users add the movie genres they are interested:");
userFirst.AddGenre(FilmGenre.Adventure);
userFirst.AddGenre(FilmGenre.ScienceFiction);
userSecond.AddGenre(FilmGenre.Adventure);

Console.WriteLine("\n\tAdd first genre:");
cinema.SetGenre(FilmGenre.Adventure);

Console.WriteLine("\n\tAdd second genre:");
cinema.SetGenre(FilmGenre.ScienceFiction);


Console.WriteLine("\n\tUnsubscribe user from the genre:");
userSecond.RemoveGenre(FilmGenre.Adventure);

cinema.SetGenre(FilmGenre.Adventure);


Console.WriteLine("\n\tEnd program");