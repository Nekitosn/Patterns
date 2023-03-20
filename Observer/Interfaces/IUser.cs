using Observer.Enums;
using Observer.Interfaces.Observers;

namespace Observer.Interfaces;

public interface IUser : ISubscribed
{
    public void AddGenre(GenreFilm genreFilm);

    public void RemoveGenre(GenreFilm genreFilm);
}