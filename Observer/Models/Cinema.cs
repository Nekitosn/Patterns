using Observer.Enums;
using Observer.Interfaces;
using Observer.Interfaces.Observers;

namespace Observer.Models;

public class Cinema : ICinema
{
    private List<ISubscribed> _subscribers;

    public Cinema()
    {
        _subscribers = new List<ISubscribed>();
    }

    public GenreFilm UpcomingFilmGenre { get; private set; }

    public void SetGenreNextFilm(GenreFilm genreFilm)
    {
        UpcomingFilmGenre = genreFilm;
        
        Notify();
    }

    public void Attach(ISubscribed subscribed)
    {
        Console.WriteLine("Cinema: Attached an subscribed.");
        _subscribers.Add(subscribed);
    }

    public void Detach(ISubscribed subscribed)
    {
        Console.WriteLine("Cinema: Detach an subscribed.");
        _subscribers.Remove(subscribed);
    }

    public void Notify()
    {
        foreach (var observer in _subscribers)
        {
            observer.Update(this);
        }
    }
}