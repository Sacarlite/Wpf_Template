namespace Domain.Factories;

public interface IFactory<TResult>
{
    TResult Create();
}