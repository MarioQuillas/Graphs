using System.Collections.Generic;

namespace Graphs.Undirected.Interfaces
{
    public interface IScannerResultfactory<TVertex, TEdge> where TEdge : IUndirectedEdge<TVertex>
    {
        IScannedGraphResult<TVertex, TEdge> CreateResult(TVertex sourceVertex, HashSet<TVertex> markedVertices,
            Dictionary<TVertex, TEdge> vertexToParentEdge);
    }
}