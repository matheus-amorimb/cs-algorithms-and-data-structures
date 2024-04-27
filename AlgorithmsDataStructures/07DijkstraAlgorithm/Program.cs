Dictionary<string, Dictionary<string, int>> graphWeighted = new Dictionary<string, Dictionary<string, int>>();

graphWeighted["A"] = new Dictionary<string, int>() { { "B", 5 }, { "C", 2 }};

graphWeighted["B"] = new Dictionary<string, int>() { { "D", 4 }, { "E", 2 }};

graphWeighted["C"] = new Dictionary<string, int>() { { "B", 8 }, { "E", 7 }};

graphWeighted["D"] = new Dictionary<string, int>() { { "E", 6 }, { "F", 3 }};

graphWeighted["E"] = new Dictionary<string, int>() { { "F", 1 }};

graphWeighted["F"] = new Dictionary<string, int>() { };

Console.WriteLine(DijkstraAlgorithm(graphWeighted, "A", "F"));

static string PrintShortestPath(string end, Dictionary<string, string> relative)
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
    
    var (nodeCosts, nodeParents) = SetInitialValues(graphWeighted, start);

    List<string> unprocessedNodes = nodeCosts.Keys.ToList();
    
    while (unprocessedNodes.Any())
    {
        string currentNode = FindLowestCost(nodeCosts, unprocessedNodes);
        
        foreach (var node in graphWeighted[currentNode])
        {
            int newPathCost = nodeCosts[currentNode] + node.Value;
            if (newPathCost < nodeCosts[node.Key])
            {
                nodeCosts[node.Key] = newPathCost;
                nodeParents[node.Key] = currentNode;
            }
        }
        unprocessedNodes.Remove(currentNode);
    }
    
    var shortestPathMessage = PrintShortestPath(end, nodeParents);

    Console.WriteLine(shortestPathMessage);
    
    return $"{nodeCosts[end]}";
}