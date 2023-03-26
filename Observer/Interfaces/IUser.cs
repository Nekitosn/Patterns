using Observer.Enums;
using Observer.Interfaces.Observers;

namespace Observer.Interfaces;

public interface IUser : ISubscriber
{
    public void AddGenre(FilmGenre filmGenre);

    public void RemoveGenre(FilmGenre filmGenre);
}