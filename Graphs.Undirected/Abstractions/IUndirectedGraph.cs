namespace Graphs.Undirected.Abstractions
{
    using System;
    using System.Collections.Generic;

    using Visitors.Abstractions;

    public interface IUndirectedGraph<TVertex, TEdge>
        where TEdge : IUndirectedEdge<TVertex> where TVertex : IEquatable<TVertex>
    {
        TResult Accept<TResult>(Func<IGraphVisitor<TResult>> vistorFactory);

        IEnumerable<TEdge> GetAdjacentsToVertex(TVertex vertex);
    }
}