using System;
using Graphs.Undirected.Abstractions;
using Graphs.Undirected.Visitors.Abstractions;

namespace Graphs.Undirected.Visitors
{
    public class BfsVisitor<TVertex, TEdge, TResult> : IGraphVisitor<TResult>
        where TEdge : IUndirectedEdge<TVertex>
        where TVertex : IEquatable<TVertex>
        where TResult : IScannedGraphResult<TVertex, TEdge>
    {
        public TResult ProduceResult()
        {
            throw new NotImplementedException();
        }
    }
}