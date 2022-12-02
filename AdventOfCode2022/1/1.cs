using System.Linq;

var sumCalsList = System.IO.File.ReadAllText(@"1/myInput.txt")
    .Split("\n\n")
    .Select(x => x.Split("\n").Where(x => x != "").Sum(int.Parse)).ToList();
sumCalsList.Sort();

Console.Out.WriteLine($"Max calories: {sumCalsList[^1]}");
Console.Out.WriteLine($"Sum of top 3 calories: {sumCalsList.TakeLast(3).Sum()}");