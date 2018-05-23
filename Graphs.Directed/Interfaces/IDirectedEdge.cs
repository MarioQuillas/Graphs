namespace Graphs.Directed.Interfaces
{
    using System;

    public interface IDirectedEdge<TVertex>
        where TVertex : IEquatable<TVertex>
    {
        TVertex Begin { get; }

        TVertex End { get; }
    }
}