using System;
using System.Collections.Generic;
using Graphs.Undirected.Visitors.Abstractions;

namespace Graphs.Undirected.Abstractions
{
    public interface IUndirectedGraph<TVertex, TEdge>
        where TEdge : IUndirectedEdge<TVertex>
        where TVertex : IEquatable<TVertex>
    {
        IEnumerable<TEdge> GetAdjacentsToVertex(TVertex vertex);

        TResult Accept<TResult>(Func<IGraphVisitor<TResult>> vistorFactory);
    }
}