using DataLayer.Model;

namespace DataLayer;

public class DataService
{

    public IList<ShowInfo> GetShowInfos()
    {
        using var db = new NorthwindContext();

        return db.ShowInfos.ToList();
    }

    public IList<Genre> GetGenres()
    {
        using var db = new NorthwindContext();

        return db.Genres.ToList();
    }

    public IList<ActorRating> GetActorRatings()
    {
        using var db = new NorthwindContext();

        return db.ActorRatings.ToList();
    }

    public IList<Character> GetCharacters()
    {
        using var db = new NorthwindContext();

        return db.Characters.ToList();
    }
}

