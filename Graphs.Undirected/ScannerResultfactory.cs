﻿using System;
using System.Collections.Generic;
using Graphs.Undirected.Abstractions;

namespace Graphs.Undirected
{
    public class ScannerResultfactory<TVertex, TEdge> : IScannerResultfactory<TVertex, TEdge>
        where TEdge : IUndirectedEdge<TVertex>
        where TVertex : IEquatable<TVertex>
    {
        public IScannedGraphResult<TVertex, TEdge> CreateResult(TVertex sourceVertex, HashSet<TVertex> markedVertices,
            Dictionary<TVertex, TEdge> vertexToParentEdge)
        {
            return new ScannedGraphResult<TVertex, TEdge>(sourceVertex, markedVertices, vertexToParentEdge);
        }
    }
}