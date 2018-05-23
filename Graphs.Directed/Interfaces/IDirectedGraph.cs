namespace Graphs.Directed.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface IDirectedGraph<TVertex, TEdge>
        where TEdge : IDirectedEdge<TVertex> where TVertex : IEquatable<TVertex>
    {
        IEnumerable<TEdge> GetVerticesFrom(TVertex vertex);
    }
}