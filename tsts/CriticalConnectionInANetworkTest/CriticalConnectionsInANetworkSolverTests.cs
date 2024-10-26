using CriticalConnectionsInANetwork;

namespace CriticalConnectionInANetworkTest;

public class CriticalConnectionsInANetworkSolverTests
{
    [Fact]
    public void ConnectionsReturnCorrectCriticalConnections()
    {
        IList<IList<int>> testList = [[0, 1], [1, 2], [2, 0], [1, 3]];
        const int testListN = 4;
        IList<IList<int>> expected = [[1, 3]];
        var solver = new CriticalConnectionsInANetworkSolver(testListN);

        var result = solver.CriticalConnections(testList);

        Assert.Equal(expected, result);
    }
}