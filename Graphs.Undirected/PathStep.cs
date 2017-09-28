namespace Graphs.Undirected
{
    using System;

    using Graphs.Undirected.Abstractions;

    public class PathStep<TVertex, TEdge>
        where TEdge : IUndirectedEdge<TVertex> where TVertex : IEquatable<TVertex>
    {
        public PathStep(TVertex startingVertex, TVertex endingVertex, TEdge travelledEdge)
        {
            this.StartingVertex = startingVertex;
            this.EndingVertex = endingVertex;
            this.TravelledEdge = travelledEdge;
        }

        public TVertex EndingVertex { get; }

        public TVertex StartingVertex { get; }

        public TEdge TravelledEdge { get; }
    }
}