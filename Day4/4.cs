using System.Linq;

var lines = System.IO.File.ReadAllLines(@"myInput.txt");

var currentSum = 0;
foreach (var line in lines)
{
    var items = line.Split(",").Select(x => (x.Split("-").Select(int.Parse)).ToArray()).ToArray();

    if (items[0][0] <= items[1][0] &&
        items[0][1] >= items[1][1])
        currentSum += 1;
    else if (items[0][0] >= items[1][0] &&
        items[0][1] <= items[1][1])
        currentSum += 1;
}

Console.WriteLine(currentSum);

currentSum = 0;
foreach (var line in lines)
{
    var items = line.Split(",").Select(x => (x.Split("-").Select(int.Parse)).ToArray()).ToArray();
    //create array of 1st item, if 2nd item any of them match, then add 1 and continue
    if (items[0][0] <= items[1][0] && items[0][1] >= items[1][0])
        currentSum += 1;
    else if (items[0][0] >= items[1][0] && items[0][0] <= items[1][1])
        currentSum += 1;
}

Console.WriteLine(currentSum);