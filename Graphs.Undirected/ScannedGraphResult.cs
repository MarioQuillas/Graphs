using System;
using System.Collections.Generic;
using Graphs.Undirected.Abstractions;

namespace Graphs.Undirected
{
    internal class ScannedGraphResult<TVertex, TEdge> : IScannedGraphResult<TVertex, TEdge>
        where TEdge : IUndirectedEdge<TVertex>
        where TVertex : IEquatable<TVertex>
    {
        public TVertex SourceVertex { get; }
        public HashSet<TVertex> MarkedVertices { get; }
        public Dictionary<TVertex, TEdge> VertexToParentEdge { get; }

        public ScannedGraphResult(TVertex sourceVertex, HashSet<TVertex> markedVertices,
            Dictionary<TVertex, TEdge> vertexToParentEdge)
        {
            this.SourceVertex = sourceVertex;
            this.MarkedVertices = markedVertices;
            this.VertexToParentEdge = vertexToParentEdge;
        }
    }
}