using Observer.Enums;
using Observer.Interfaces;
using Observer.Interfaces.Observers;

namespace Observer.Models;

public class Admin : IAdmin
{
    public Admin()
    {
        SubscribedGenres = new List<FilmGenre>();
        
        var filmGenres = Enum.GetValues(typeof(FilmGenre)).Cast<FilmGenre>().ToList();
        SubscribedGenres.AddRange(filmGenres);
    }

    public List<FilmGenre> SubscribedGenres { get; }
    
    public void Update(IPublisher publisher)
    {
        var filmGenre = ((publisher as Cinema)!).UpcomingFilmGenre;
        
        if(SubscribedGenres.Contains(filmGenre))
        {
            Console.WriteLine($"A movie with the {filmGenre} genre is coming out soon. Check the poster for errors."); 
        }
    }
}