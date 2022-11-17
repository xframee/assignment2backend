using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;


namespace DataLayer;

public class DataService
{

    public IList<ShowInfo> GetShowInfos()
    {
        using var db = new NorthwindContext();

        return db.ShowInfos.ToList();
    }

    public IList<ShowInfo> GetShowInfo(string tconst)
    {
        using var db = new NorthwindContext();

        return db.ShowInfos
            .Where(x => x.TConst.Equals(tconst))
            .ToList();
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

    public IList<Profession> GetProfessions()
    {
        using var db = new NorthwindContext();

        return db.Professions.ToList();
    }

    public IList<RecentlyVisited> GetRecentlyVisiteds()
    {
        using var db = new NorthwindContext();

        return db.RecentlyVisiteds.ToList();
    }

    public IList<SearchHistory> GetSearchHistories()
    {
        using var db = new NorthwindContext();

        return db.SearchHistories.ToList();
    }
    
    public IList<ShowPrincipal> GetShowPrincipals()
    {
        using var db = new NorthwindContext();

        return db.ShowPrincipals.ToList();
    }

    public IList<ShowRating> GetShowRatings()
    {
        using var db = new NorthwindContext();

        return db.ShowRatings.ToList();
    }

    public IList<UserBookmark> GetUserBookmarks()
    {
        using var db = new NorthwindContext();

        return db.UserBookmarks.ToList();
    }

    public IList<UserRating> GetUserRatings()
    {
        using var db = new NorthwindContext();

        return db.UserRatings.ToList();
    }

    public IList<User> GetUsers()
    {
        using var db = new NorthwindContext();

        return db.Users.ToList();
    }

    public IList<Wi> GetWis()
    {
        using var db = new NorthwindContext();

        return db.Wis.ToList();
    }

    public IList<Writer> GetWriters()
    {
        using var db = new NorthwindContext();

        return db.Writers.ToList();
    }
}