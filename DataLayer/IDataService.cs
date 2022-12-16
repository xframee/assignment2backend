using System;
using DataLayer.Model;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IDataService
    {
        IList<ShowInfo> GetShowInfos(int page, int pageSize);
        ShowInfo? GetShowInfo(string Id);
        IList<ShowInfo> GetLimitedShowInfo(int limit);
        void CreateShowInfo(ShowInfo showinfo);
        bool DeleteShowInfo(string Id);
        bool UpdateShowInfo(ShowInfo showinfo);
        IList<ShowInfoSearchModel>GetShowInfoByName(string search, int page, int pageSize);
        IList<Genre> GetGenres();
        IList<ActorRating> GetActorRatings();
        IList<Character> GetCharacters();
        IList<Director> GetDirectors();
        IList<EpisodeInfo> GetEpisodeInfos();
        IList<KnownFor> GetKnownFors();
        IList<OMDBData> GetOMDBDatas();
        IList<Person> GetPeople();
        IList<Profession> GetProfessions();
        IList<RecentlyVisited> GetRecentlyVisiteds();
        IList<SearchHistory> GetSearchHistories();
        IList<ShowPrincipal> GetShowPrincipals();
        IList<ShowRating> GetShowRatings();
        IList<UserBookmark> GetUserBookmarks();
        IList<UserRating> GetUserRatings();
        IList<User> GetUsers();
        User? GetUser(string UserId);
        void CreateUser(User user);
        bool DeleteUser(string Username);
        IList<Writer> GetWriters();
    }
}

