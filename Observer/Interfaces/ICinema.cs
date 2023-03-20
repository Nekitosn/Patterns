using Observer.Enums;
using Observer.Interfaces.Observers;

namespace Observer.Interfaces;

public interface ICinema : IPublisher
{
    public void SetGenreNextFilm(GenreFilm genreFilm);
}