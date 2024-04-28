
SetCoverProblem();

static HashSet<string> SetCoverProblem()
{
    HashSet<string> statesToCover = new HashSet<string>()
    {
        "mt", "wa", "or", "id", "nv", "ut", "ca", "az"
    };

    Dictionary<string, HashSet<string>> stations = new Dictionary<string, HashSet<string>>()
    {
        { "kum", new HashSet<string>() { "id", "nv", "ut" } },
        { "kdois", new HashSet<string>() { "wa", "id", "mt" } },
        { "ktres", new HashSet<string>() { "or", "nv", "ca" } },
        { "kquatro", new HashSet<string>() { "nv", "ut" } },
        { "kcinco", new HashSet<string>() { "ca", "az" } }
    };

    HashSet<string> finalStations = new HashSet<string>(){};
    HashSet<string> coveredArea = new HashSet<string>() { };
    HashSet<string> cover = new HashSet<string>() { };
    string bestStation = "";

    while (statesToCover.Any())
    {
        coveredArea.Clear();
        foreach (var station in stations)
        {
            cover = statesToCover.Intersect(station.Value).ToHashSet();
            if (coveredArea.Count < cover.Count)
            {
                coveredArea = cover;
                bestStation = station.Key;
            }
        }

        finalStations.Add(bestStation);
        statesToCover.ExceptWith(coveredArea);
    }

    foreach (var station in finalStations)
    {
        Console.Write($"{station}, ");
    }

    return finalStations;
}