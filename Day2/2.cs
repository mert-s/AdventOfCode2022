using System.Linq;

var lines = System.IO.File.ReadAllLines(@"myInput.txt");

var allCasesPart1 = new Dictionary<string, int> {
    { "A X", 1+3 },
    { "A Y", 2+6 },
    { "A Z", 3 },
    { "B X", 1 },
    { "B Y", 2+3 },
    { "B Z", 3+6 },
    { "C X", 1+6 },
    { "C Y", 2 },
    { "C Z", 3+3 },
};

var total = lines.Sum(x => allCasesPart1[x]);

Console.Out.WriteLine($"Part 1: {total}");

var allCasesPart2 = new Dictionary<string, int> {
    { "A X", 3 },
    { "A Y", 1+3 },
    { "A Z", 2+6 },
    { "B X", 1 },
    { "B Y", 2+3 },
    { "B Z", 3+6 },
    { "C X", 2 },
    { "C Y", 3+3 },
    { "C Z", 1+6 },
};

var total2 = lines.Sum(x => allCasesPart2[x]);

Console.Out.WriteLine($"Part 2: {total2}");