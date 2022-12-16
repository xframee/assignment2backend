using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;


namespace DataLayer;

public class DataService : IDataService
{

    public IList<ShowInfo> GetShowInfos(int page, int pageSize)
    {
        using var db = new NorthwindContext();

        return db.ShowInfos
            .Skip(page * pageSize)
            .Take(pageSize)
            .ToList();
    }

    public ShowInfo? GetShowInfo(string showInfoId)
    {
        using var db = new NorthwindContext();

        return db.ShowInfos.Find(showInfoId);
    }

    public IList<ShowInfo> GetLimitedShowInfo(int limit)
    {
        using var db = new NorthwindContext();

        return db.ShowInfos
            .Take(limit)
            .ToList();
    }

    public void CreateShowInfo(ShowInfo showinfo)
    {
        using var db = new NorthwindContext();
        showinfo.ShowInfoId = db.ShowInfos.Any() ? db.ShowInfos.Max(x => x.ShowInfoId) + 1 : "tt0052520"; //det her virker ikke som det skal
        db.ShowInfos.Add(showinfo);
        db.SaveChanges();
    }

    public bool DeleteShowInfo (string showInfoId)
    {
        using var db = new NorthwindContext();
        var showInfo = db.ShowInfos.Find(showInfoId);
        db.ShowInfos.Remove(showInfo);
        return db.SaveChanges() > 0;
    }

    public bool UpdateShowInfo(ShowInfo showinfo)
    {
        using var db = new NorthwindContext();
        var dbShowInfo = db.ShowInfos.Find(showinfo.ShowInfoId);
        if (dbShowInfo == null) return false;
        dbShowInfo.Type = showinfo.Type;
        dbShowInfo.PrimaryTitle = showinfo.PrimaryTitle;
        dbShowInfo.OriginalTitle = showinfo.OriginalTitle;
        dbShowInfo.IsAdult = showinfo.IsAdult;
        dbShowInfo.StartYear = showinfo.StartYear;
        dbShowInfo.EndYear = showinfo.EndYear;
        dbShowInfo.RunTime = showinfo.RunTime;
        db.SaveChanges();
        return true;
    }

    public IList<ShowInfoSearchModel> GetShowInfoByName(string search, int page, int pageSize)
    {
        using var db = new NorthwindContext();
        return db.ShowInfos
            .Where(x => x.PrimaryTitle.ToLower().Contains(search.ToLower()))
            .Select(x => new ShowInfoSearchModel
            {
                Title = x.PrimaryTitle,
                StartYear = x.StartYear,
                Poster = x.Poster
            })
            .Skip(page * pageSize)
            .Take(pageSize)
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

    public User? GetUser(string UserId)
    {
        using var db = new NorthwindContext();

        return db.Users.Find(UserId);
    }


    public void CreateUser(User user)
    {
        using var db = new NorthwindContext();
        //user.Username = HashUsername(user.Usermame);
        db.Users.Add(user);
        db.SaveChanges();
    }

    public bool DeleteUser(string Username)
    {
        using var db = new NorthwindContext();
        var user = db.Users.Find(Username);
        db.Users.Remove(user);
        return db.SaveChanges() > 0;
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