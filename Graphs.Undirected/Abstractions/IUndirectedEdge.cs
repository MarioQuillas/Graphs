namespace Graphs.Undirected.Abstractions
{
    using System;

    public interface IUndirectedEdge<TVertex>
        where TVertex : IEquatable<TVertex>
    {
        bool ContainVertex(TVertex vertex);

        // TODO : A better design should be return a Maybe<TVertex>
        TVertex GetOtherVertex(TVertex currentVertex);
    }
}