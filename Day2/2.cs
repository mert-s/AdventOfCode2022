using System.Linq;

var lines = System.IO.File.ReadAllLines(@"myInput.txt");

var allCases = new Dictionary<string, int> {
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

var total = lines.Sum(x => allCases[x]);

Console.Out.WriteLine($"{total}");