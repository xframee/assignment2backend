using System;
using EF;

using var db = new NorthwindContext();

foreach (var genre in db.Genres)
{
    Console.WriteLine(genre.Genre);
}
