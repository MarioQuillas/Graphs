namespace Graphs.Undirected.Abstractions
{
    using System;

    public interface IScannerGraphAlgorithm<TVertex, TEdge>
        where TEdge : IUndirectedEdge<TVertex> where TVertex : IEquatable<TVertex>
    {
        IScannedGraphResult<TVertex, TEdge> TraverseGraph(
            IUndirectedGraph<TVertex, TEdge> undirectedGraph,
            TVertex sourceVertex);
    }
}