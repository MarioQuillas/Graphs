using System;

namespace Graphs.Undirected.Abstractions
{
    public interface IScannerGraphAlgorithm<TVertex, TEdge> 
        where TEdge : IUndirectedEdge<TVertex>
        where TVertex : IEquatable<TVertex>
    {
        IScannedGraphResult<TVertex, TEdge> TraverseGraph(IUndirectedGraph<TVertex, TEdge> undirectedGraph, TVertex sourceVertex);
    }
}