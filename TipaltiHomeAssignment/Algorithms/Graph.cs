using System;
using System.Collections.Generic;
using System.Linq;

public class Graph<T>
{
    private Dictionary<T, HashSet<T>> adjacencyList = new Dictionary<T, HashSet<T>>();

    // Add an edge between two nodes in an undirected graph
    public void AddEdge(T source, T destination)
    {
        if (!adjacencyList.ContainsKey(source))
        {
            adjacencyList.Add(source, new HashSet<T>());
        }
        if (!adjacencyList.ContainsKey(destination))
        {
            adjacencyList.Add(destination, new HashSet<T>());
        }

         adjacencyList[source].Add(destination);
         adjacencyList[destination].Add(source); // For an undirected graph
    }

    // Find the length of the shortest path between source and destination nodes
    // Returns -1 if no path exists
    public int ShortestPathLength(T source, T destination)
    {
        Dictionary<T, int> distances = new Dictionary<T, int>();
        Queue<T> queue = new Queue<T>();

        foreach (var node in adjacencyList.Keys)
        {
            distances[node] = int.MaxValue;
        }

        distances[source] = 0;
        queue.Enqueue(source);

        while (queue.Any())
        {
            T currentNode = queue.Dequeue();

            foreach (var neighbor in adjacencyList[currentNode])
            {
                if (distances[neighbor] == int.MaxValue)
                {
                    distances[neighbor] = distances[currentNode] + 1;
                    queue.Enqueue(neighbor);

                    if (neighbor.Equals(destination))
                    {
                        return distances[neighbor];
                    }
                }
            }
        }

        return -1; // If no path exists
    }
}
