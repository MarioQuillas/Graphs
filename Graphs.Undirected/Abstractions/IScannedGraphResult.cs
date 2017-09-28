namespace Graphs.Undirected.Abstractions
{
    using System;
    using System.Collections.Generic;

    public interface IScannedGraphResult<TVertex, TEdge>
        where TEdge : IUndirectedEdge<TVertex> where TVertex : IEquatable<TVertex>
    {
        HashSet<TVertex> MarkedVertices { get; }

        TVertex SourceVertex { get; }

        Dictionary<TVertex, TEdge> VertexToParentEdge { get; }
    }
}