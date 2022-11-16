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

*/

var genrestest = ds.GetGenresTest();

foreach (var genre in genrestest)
{
    Console.WriteLine($"Tconst: {genre.TConst}, Genre: {genre.MovieGenre} ");
}
