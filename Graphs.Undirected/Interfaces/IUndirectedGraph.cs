using System.Collections.Generic;

namespace Graphs.Undirected.Interfaces
{
    public interface IUndirectedGraph<TVertex, TEdge> where TEdge : IUndirectedEdge<TVertex>
    {
        IEnumerable<TEdge> GetAdjacentsToVertex(TVertex vertex);
    }
}