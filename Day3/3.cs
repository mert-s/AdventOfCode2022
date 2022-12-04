using System.Linq;

var lines = System.IO.File.ReadAllLines(@"myInput.txt");

var sum = 0;
foreach (var line in lines)
{
    var parts = line.ToCharArray();

    var sharedItem = parts[..(parts.Length / 2)]
        .Intersect(parts[(parts.Length / 2)..])
        .First();
    sum += char.IsUpper(sharedItem) ? sharedItem - 38 : sharedItem - 96;
}

Console.WriteLine($"Part 1: {sum}");

//part 2:

var sum2 = 0;
for(int i = 0; i < lines.Length; i += 3)
{
    var sharedItem = lines[i].ToCharArray()
        .Intersect(lines[i + 1].ToCharArray())
        .Intersect(lines[i + 2].ToCharArray())
        .First();

    sum2 += char.IsUpper(sharedItem) ? sharedItem - 38 : sharedItem - 96;
}

Console.WriteLine($"Part 2: {sum2}");