using System;

namespace Graphs.Undirected.Abstractions
{
    public interface IUndirectedEdge<TVertex> where TVertex:IEquatable<TVertex>
    {
        //TODO : A better design should be return a Maybe<TVertex>
        TVertex GetOtherVertex(TVertex currentVertex);
        bool ContainVertex(TVertex vertex);
    }
}