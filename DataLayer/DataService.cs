using DataLayer.Model;

namespace DataLayer;

public class DataService
{

    public IList<ShowInfo> GetShowInfos()
    {
        using var db = new NorthwindContext();

        return db.ShowInfos.ToList();
    }

    public IList<Genre> GetGenresTest()
    {
        using var db = new NorthwindContext();

        return db.Genres.ToList();
    }
}

