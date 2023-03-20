using Observer.Enums;
using Observer.Interfaces;
using Observer.Interfaces.Observers;

namespace Observer.Models;

public class Admin : IAdmin
{
    public Admin()
    {
        SubscribedGenres = new List<GenreFilm>();
        
        var genreFilms = Enum.GetValues(typeof(GenreFilm)).Cast<GenreFilm>().ToList();
        SubscribedGenres.AddRange(genreFilms);
    }

    public List<GenreFilm> SubscribedGenres { get; }
    
    public void Update(IPublisher publisher)
    {
        var genreFilm = ((publisher as Cinema)!).UpcomingFilmGenre;
        
        if(SubscribedGenres.Contains(genreFilm))
        {
            Console.WriteLine($"A movie with the {genreFilm} genre is coming out soon. Check the poster for errors."); 
        }
    }
}