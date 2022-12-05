using System.Linq;
using System.Text.RegularExpressions;

var lines = System.IO.File.ReadAllLines(@"myInput.txt").ToList();

var stackBottom = lines.First(x => x.Contains("1"));
var index = lines.IndexOf(stackBottom);
var stringIndices = stackBottom.Where(x => x != ' ').ToDictionary(x => stackBottom.IndexOf(x), x => (int)char.GetNumericValue(x));

List<Stack<char>> stacks = Enumerable.Range(1, stringIndices.Count).Select(_ => new Stack<char>()).ToList();
for (int i = index - 1; i >= 1; i--)
{
    var thisRow = lines[i];
    for (int j = 0; j < thisRow.Length; j++)
    {
        if(char.IsLetter(thisRow[j]))
            stacks[stringIndices[j]-1].Push(thisRow[j]);
    }
}

//input stack parser above working, output currently broken
foreach (var line in lines)
{
    if (line.StartsWith("move"))
    {
        var resultString = Regex.Matches(line, @"\d+").Select(x => int.Parse(x.Value)).ToArray();

        for (int i = 0; i < resultString[0]; i++)
        {
            if(stacks[resultString[1]-1].TryPop(out var popped))
                stacks[resultString[2]-1].Push(popped);
        }
    }
}

foreach (var stack in stacks)
{
    stack.TryPeek(out var item);
    Console.WriteLine(item);
}
Console.WriteLine();