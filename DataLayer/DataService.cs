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

    public IList<Director> GetDirectors()
    {
        using var db = new NorthwindContext();

        return db.Directors.ToList();
    }

    public IList<EpisodeInfo> GetEpisodeInfos()
    {
        using var db = new NorthwindContext();

        return db.EpisodeInfos.ToList();
    }

    public IList<KnownFor> GetKnownFors()
    {
        using var db = new NorthwindContext();

        return db.KnownFors.ToList();
    }

    public IList<OMDBData> GetOMDBDatas()
    {
        using var db = new NorthwindContext();

        return db.OMDBDatas.ToList();
    }

    public IList<Person> GetPeople()
    {
        using var db = new NorthwindContext();

        return db.People.ToList();
    }
}