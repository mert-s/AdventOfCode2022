var input = System.IO.File.ReadAllText(@"myInput.txt");

static int GetFirstMarker(int distinctCharacters, string input)
{
    for (int i = distinctCharacters - 1; i < input.Length; i++)
    {
        if (new HashSet<char>(input[(i - distinctCharacters + 1)..(i+1)]).Count == distinctCharacters)
            return i + 1;
    }
    return int.MaxValue;
}

Console.WriteLine($"Part 1: {GetFirstMarker(4, input)}");
Console.WriteLine($"Part 1: {GetFirstMarker(14, input)}");