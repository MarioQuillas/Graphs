using System;
using Graphs.Undirected.Abstractions;

namespace Graphs.Undirected
{
    public class PathStep<TVertex, TEdge> 
        where TEdge : IUndirectedEdge<TVertex>
        where TVertex : IEquatable<TVertex>
    {
        public TVertex StartingVertex { get; }
        public TVertex EndingVertex { get; }
        public TEdge TravelledEdge { get; }

        public PathStep(TVertex startingVertex, TVertex endingVertex, TEdge travelledEdge)
        {
            StartingVertex = startingVertex;
            EndingVertex = endingVertex;
            TravelledEdge = travelledEdge;
        }
    }
}