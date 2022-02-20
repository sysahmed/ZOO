namespace ZOO.Core.Entities.Results
{
    public interface IDataResult<out T> : IResult
    {
        T Data { get; }
    }
}
