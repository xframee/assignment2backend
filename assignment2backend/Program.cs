using EF;

using var db = new NorthwindContext();

foreach (var info in db.ShowInfos)
{
    Console.WriteLine(info.TConst);
}
