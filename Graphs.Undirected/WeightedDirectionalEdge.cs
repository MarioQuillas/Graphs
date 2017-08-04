﻿namespace Graphs.Undirected
{
    internal class WeightedDirectionalEdge<TVertex>
    {
        public TVertex Source { get; }
        public TVertex Target { get; }
        public decimal Weight { get; }

        public WeightedDirectionalEdge(TVertex source, TVertex target, decimal weight)
        {
            this.Source = source;
            this.Target = target;
            this.Weight = weight;
        }

    }
}