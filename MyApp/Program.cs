using System;
using DataLayer;
using DataLayer.Model;

var ds = new DataService();

/*
var showinfos = ds.GetShowInfos();

foreach (var info in showinfos)
{
    Console.WriteLine(info.PrimaryTitle);
}


var genres = ds.GetGenres();

foreach (var genre in genres)
{
    Console.WriteLine($"Tconst: {genre.TConst}, Genre: {genre.MovieGenre} ");
}


var actorRatings = ds.GetActorRatings();

foreach (var rating in actorRatings)
{
    Console.WriteLine($"Nconst: {rating.NConst}, Rating: {rating.Rating}");
}



var characters = ds.GetCharacters();
foreach (var character in characters)
{
    Console.WriteLine(character.CharacterPlayed);
}



var directors = ds.GetDirectors();

foreach (var director in directors)
{
    Console.WriteLine(director.NConst);
}



var episodeInfos = ds.GetEpisodeInfos();

foreach (var info in episodeInfos)
{
    Console.WriteLine(info.TConst);
}


var knownfors = ds.GetKnownFors();

foreach (var knownfor in knownfors)
{
    Console.WriteLine(knownfor.NConst);
}

var omdbdatas = ds.GetOMDBDatas();

foreach (var omdbdata in omdbdatas)
{
    Console.WriteLine(omdbdata.Plot);
}


var people = ds.GetPeople();

foreach (var person in people)
{
    Console.WriteLine(person.Name);
}

var professions = ds.GetProfessions();

foreach (var profession in professions)
{
    Console.WriteLine(profession.PersonProfession);
}


var recentlyVisiteds = ds.GetRecentlyVisiteds();

foreach (var item in recentlyVisiteds)
{
    Console.WriteLine(item.Username);
}



var searchHistories = ds.GetSearchHistories();

foreach (var item in searchHistories)
{
    Console.WriteLine(item.Username);
}



var showPrincipals = ds.GetShowPrincipals();

foreach (var principal in showPrincipals)
{
    Console.WriteLine(principal.Job);
}

var showRatings = ds.GetShowRatings();

foreach (var rating in showRatings)
{
    Console.WriteLine(rating.NumVotes);
}

var userBookmarks = ds.GetUserBookmarks();

foreach (var bookmark in userBookmarks)
{
    Console.WriteLine(bookmark.Username);
}


var userRatings = ds.GetUserRatings();

foreach (var rating in userRatings)
{
    Console.WriteLine(rating.Rating);
}

var users = ds.GetUsers();

foreach (var user in users)
{
    Console.WriteLine(user.Password);
}

var Wis = ds.GetWis();

foreach (var wi in Wis)
{
    Console.WriteLine(wi.Field);
}

var Writers = ds.GetWriters();

foreach (var writer in Writers)
{
    Console.WriteLine(writer.TConst);
}


var test = ds.GetShowInfo("tt12508898");

foreach (var item in test)
{
    Console.WriteLine(item.TConst);
}

*/
