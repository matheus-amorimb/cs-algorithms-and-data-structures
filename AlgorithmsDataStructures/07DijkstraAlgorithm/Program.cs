Dictionary<string, Dictionary<string, int>> graphWeighted = new Dictionary<string, Dictionary<string, int>>();

graphWeighted["Livro"] = new Dictionary<string, int>()
{
    { "LP Raro", 5 },
    { "Postêr", 0 },
};

graphWeighted["LP Raro"] = new Dictionary<string, int>()
{
    { "Bateria", 20 },
    { "Baixo", 15 },
};

graphWeighted["Postêr"] = new Dictionary<string, int>()
{
    { "Bateria", 35 },
    { "Baixo", 30 },
};

graphWeighted["Bateria"] = new Dictionary<string, int>()
{
    { "Piano", 10 },
};

graphWeighted["Baixo"] = new Dictionary<string, int>()
{
    { "Piano", 10 },
};

graphWeighted["Piano"] = new Dictionary<string, int>()
{ };

Console.WriteLine(DijkstraAlgorithm(graphWeighted, "Livro", "Baixo"));

static string PrintNodesRelation(string end, Dictionary<string, string> relative)
{
    string message = $"{end} <==== ";
    string lastElement = end;
    while (relative.TryGetValue(lastElement, out string father))
    {
        lastElement = father;
        message += $"{lastElement} <==== ";
    }

    message = message.Remove(message.Length - 6, 5);
    return message;
}

static (Dictionary<string, int>, Dictionary<string, string>) SetInitialValues(Dictionary<string, Dictionary<string, int>> graphWeighted, string start){
    Dictionary<string, int> costs = new Dictionary<string, int>();
    Dictionary<string, string> relative = new Dictionary<string, string>();

    foreach (var key in graphWeighted.Keys)
    {
        if (key == start)
        {
            continue;
        }

        var startValue = graphWeighted.GetValueOrDefault(start);

        int keyValue;
        if (startValue.TryGetValue(key, out keyValue))
        {
            costs.Add(key, keyValue);
            relative.Add(key, start);
        }
        else
        {
            costs.Add(key, Int32.MaxValue);
            relative.Add(key, "-");
        }
    }
    return (costs, relative);
}


static string FindLowestCost(Dictionary<string, int> costs, List<string> nodesToProcess)
{
    int lowestValue = Int32.MaxValue;
    foreach (var cost in costs.Keys)
    {
        if (costs[cost] < lowestValue && nodesToProcess.Contains(cost))
        {
            lowestValue = costs[cost];
        }
    }

    return costs.FirstOrDefault(dict => dict.Value == lowestValue).Key;
    
}

static string DijkstraAlgorithm(Dictionary<string, Dictionary<string, int>> graphWeighted, string start, string end)
{
    if (!graphWeighted.ContainsKey(end))
    {
        return $"There is path to {end}";
    }
    
    var (costs, relative) = SetInitialValues(graphWeighted, start);

    var costAux = costs;

    List<string> nodesToProcess = costs.Keys.ToList();
    
    while (nodesToProcess.Any())
    {
        string lowestCost = FindLowestCost(costs, nodesToProcess);
        
        foreach (var node in graphWeighted[lowestCost])
        {
            if (node.Value < costs[node.Key])
            {
                costs[node.Key] = node.Value + costs[lowestCost];
                relative[node.Key] = lowestCost;
            }
        }
        nodesToProcess.Remove(lowestCost);
    }
    
    var message = PrintNodesRelation(end, relative);

    Console.WriteLine(message);
    
    return $"{costs[end]}";
}