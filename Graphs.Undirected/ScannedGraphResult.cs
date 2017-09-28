namespace Graphs.Undirected
{
    using System;
    using System.Collections.Generic;

    using Graphs.Undirected.Abstractions;

    internal class ScannedGraphResult<TVertex, TEdge> : IScannedGraphResult<TVertex, TEdge>
        where TEdge : IUndirectedEdge<TVertex> where TVertex : IEquatable<TVertex>
    {
        public ScannedGraphResult(
            TVertex sourceVertex,
            HashSet<TVertex> markedVertices,
            Dictionary<TVertex, TEdge> vertexToParentEdge)
        {
            this.SourceVertex = sourceVertex;
            this.MarkedVertices = markedVertices;
            this.VertexToParentEdge = vertexToParentEdge;
        }

        public HashSet<TVertex> MarkedVertices { get; }

        public TVertex SourceVertex { get; }

        public Dictionary<TVertex, TEdge> VertexToParentEdge { get; }
    }
}