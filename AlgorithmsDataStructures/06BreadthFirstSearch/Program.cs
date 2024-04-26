Dictionary<string, string[]> graph = new Dictionary<string, string[]>();

graph["matheus"] = new string[] { "Luan", "Lohana", "Beatriz", "Cris" };
graph["Cris"] = new string[] { "Zirlanda" };
graph["Beatriz"] = new string[] { "Ricardo" };
graph["Luan"] = new string[] { "Cris", "Layana", "Peter" };
graph["Lohana"] = new string[] {"Matheus"};

Console.WriteLine(BreadthFirstSearch(graph, "matheus"));

static bool isSeller(string name)
{
    return name.Contains("seller", StringComparison.OrdinalIgnoreCase);
}

static string BreadthFirstSearch(Dictionary<string, string[]> graph, string firstPerson)
{
    Queue<string> people = new Queue<string>();
    List<string> peopleChecked = new List<string>(); 

    foreach (var person in graph[firstPerson])
    {
        people.Enqueue(person);
    }

    while (people.Count > 0)
    {
        string individual = people.Dequeue();
        
        if (isSeller(individual))
        {
            return individual;
        }
        else
        {
            if (!peopleChecked.Contains(individual))
            {
                if (graph.ContainsKey(individual))
                {
                    foreach (var person in graph[individual])
                    {
                        people.Enqueue(person);
                    }   
                }
                peopleChecked.Add(individual);
            }
        }   
    }
    
    return "There is no seller";
}

