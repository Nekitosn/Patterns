using System.Threading.Channels;
using Observer.Enums;
using Observer.Interfaces;
using Observer.Interfaces.Observers;

namespace Observer.Models;

public class User : IUser
{
    public User()
    {
        SubscribedGenres = new List<FilmGenre>();
    }

    public List<FilmGenre> SubscribedGenres { get; }

    public void AddGenre(FilmGenre filmGenre)
    {
        if (SubscribedGenres.Contains(filmGenre))
        {
            return;
        }

        SubscribedGenres.Add(filmGenre);
        Console.WriteLine($"You have subscribed to notifications about {filmGenre}.");
    }

    public void RemoveGenre(FilmGenre filmGenre)
    {
        if (SubscribedGenres.Contains(filmGenre))
        {
            SubscribedGenres.Remove(filmGenre);
            Console.WriteLine($"You have unsubscribed to notifications about {filmGenre}.");
        }
    }
    
    public void Update(IPublisher publisher)
    {
        var filmGenre = ((publisher as Cinema)!).UpcomingFilmGenre;
        
        if(SubscribedGenres.Contains(filmGenre))
        {
            Console.WriteLine($"A movie with the {filmGenre} genre is coming out soon."); 
        }
    }
}