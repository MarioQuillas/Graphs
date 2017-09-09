namespace Graphs.Undirected.Visitors.Abstractions
{
    public interface IGraphVisitor<TResult>
    {
        TResult ProduceResult();
    }
}