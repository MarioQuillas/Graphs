namespace Graphs.Undirected.Abstractions
{
    using System;
    using System.Collections.Generic;

    public interface IScannerResultfactory<TVertex, TEdge>
        where TEdge : IUndirectedEdge<TVertex> where TVertex : IEquatable<TVertex>
    {
        IScannedGraphResult<TVertex, TEdge> CreateResult(
            TVertex sourceVertex,
            HashSet<TVertex> markedVertices,
            Dictionary<TVertex, TEdge> vertexToParentEdge);
    }
}