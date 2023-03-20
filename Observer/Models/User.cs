using System.Threading.Channels;
using Observer.Enums;
using Observer.Interfaces;
using Observer.Interfaces.Observers;

namespace Observer.Models;

public class User : IUser
{
    public User()
    {
        SubscribedGenres = new List<GenreFilm>();
    }

    public List<GenreFilm> SubscribedGenres { get; }

    public void AddGenre(GenreFilm genreFilm)
    {
        if (SubscribedGenres.Any(subscribedGenre => subscribedGenre == genreFilm))
        {
            return;
        }

        Console.WriteLine($"You have subscribed to notifications about {genreFilm}.");
        SubscribedGenres.Add(genreFilm);
    }

    public void RemoveGenre(GenreFilm genreFilm)
    {
        if (SubscribedGenres.Any(subscribedGenre => subscribedGenre == genreFilm))
        {
            Console.WriteLine($"You have unsubscribed to notifications about {genreFilm}.");
            SubscribedGenres.Remove(genreFilm);
        }
    }
    
    public void Update(IPublisher publisher)
    {
        var genreFilm = ((publisher as Cinema)!).UpcomingFilmGenre;
        
        if(SubscribedGenres.Contains(genreFilm))
        {
            Console.WriteLine($"A movie with the {genreFilm} genre is coming out soon."); 
        }
    }
}