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
*/

var people = ds.GetPeople();

foreach (var person in people)
{
    Console.WriteLine(person.Name);
}