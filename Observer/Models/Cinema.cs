using Observer.Enums;
using Observer.Interfaces;
using Observer.Interfaces.Observers;

namespace Observer.Models;

public class Cinema : ICinema
{
    private List<ISubscriber> _subscribers;

    public Cinema()
    {
        _subscribers = new List<ISubscriber>();
    }

    public FilmGenre UpcomingFilmGenre { get; private set; }

    public void SetGenre(FilmGenre filmGenre)
    {
        UpcomingFilmGenre = filmGenre;
        
        Notify();
    }

    public void Attach(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
        Console.WriteLine("Cinema: Attached the subscriber.");
    }

    public void Detach(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
        Console.WriteLine("Cinema: Detach the subscriber.");
    }

    public void Notify()
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Update(this);
        }
    }
}