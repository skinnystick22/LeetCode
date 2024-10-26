namespace CriticalConnectionsInANetwork;

public class CriticalConnectionsInANetworkSolver
{
    private readonly List<IList<int>> _bridges;
    private readonly List<int>[] _graph;
    private readonly int[] _disc; // Discovery time of nodes
    private readonly int[] _low;  // Low-link values of nodes
    private int _time;
    private readonly int _n;

    public CriticalConnectionsInANetworkSolver(int n)
    {
        _bridges = [];
        _graph = new List<int>[n];
        _disc = new int[n];
        _low = new int[n];
        _time = 0;
        _n = n;
    }

    public IList<IList<int>> CriticalConnections(IList<IList<int>> connections)
    {
        // Build the graph
        BuildGraph(connections);

        // Initialize discovery times to -1 (unvisited)
        Array.Fill(_disc, -1);

        // Start DFS from node 0 (assuming the graph is connected)
        DFS(0, -1);

        return _bridges;
    }

    private void BuildGraph(IList<IList<int>> connections)
    {
        for (var i = 0; i < _n; i++)
            _graph[i] = [];

        foreach (var conn in connections)
        {
            var u = conn[0];
            var v = conn[1];
            _graph[u].Add(v);
            _graph[v].Add(u);
        }
    }

    private void DFS(int u, int parent)
    {
        // Set discovery time and low-link value
        _disc[u] = _low[u] = _time++;
        foreach (var v in _graph[u])
        {
            if (v == parent)
                continue; // Skip the parent node

            if (_disc[v] == -1)
            {
                // If v is not visited, recurse on it
                DFS(v, u);
                // Update the low-link value after visiting children
                _low[u] = Math.Min(_low[u], _low[v]);

                // Check if the edge is a bridge
                if (_low[v] > _disc[u])
                    _bridges.Add(new List<int> { u, v });
            }
            else
            {
                // Update low-link value for back edge
                _low[u] = Math.Min(_low[u], _disc[v]);
            }
        }
    }
}