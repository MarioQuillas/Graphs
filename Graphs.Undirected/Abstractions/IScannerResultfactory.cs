using System;
using System.Collections.Generic;

namespace Graphs.Undirected.Abstractions
{
    public interface IScannerResultfactory<TVertex, TEdge>
        where TEdge : IUndirectedEdge<TVertex>
        where TVertex : IEquatable<TVertex>
    {
        IScannedGraphResult<TVertex, TEdge> CreateResult(TVertex sourceVertex, HashSet<TVertex> markedVertices,
            Dictionary<TVertex, TEdge> vertexToParentEdge);
    }
}