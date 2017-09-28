namespace Graphs.Undirected
{
    using System;
    using System.Collections.Generic;

    using Graphs.Undirected.Abstractions;

    public class DfsScanner<TVertex, TEdge> : IScannerGraphAlgorithm<TVertex, TEdge>
        where TEdge : IUndirectedEdge<TVertex> where TVertex : IEquatable<TVertex>
    {
        private readonly IScannerResultfactory<TVertex, TEdge> scannerResultfactory;

        public DfsScanner(IScannerResultfactory<TVertex, TEdge> scannerResultfactory)
        {
            this.scannerResultfactory = scannerResultfactory;
        }

        public IScannedGraphResult<TVertex, TEdge> TraverseGraph(
            IUndirectedGraph<TVertex, TEdge> undirectedGraph,
            TVertex sourceVertex)
        {
            var markedVertices = new HashSet<TVertex>();
            var vertexToParentEdge = new Dictionary<TVertex, TEdge>();

            var toto = undirectedGraph.GetAdjacentsToVertex(sourceVertex);
            foreach (var edge in toto)
            {
            }

            return this.scannerResultfactory.CreateResult(sourceVertex, markedVertices, vertexToParentEdge);
        }
    }
}