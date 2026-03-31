namespace Assignment1.Constraints;

public interface IEntity
{
    int Id { get; set; }
}

public class EntityManager<T> where T : class, IEntity, new()
{
    public T CreateAndSave()
    {
        var entity = new T();
        entity.Id = Guid.NewGuid().GetHashCode();
        return entity;
    }

    public bool IsNull(T entity)
    {
        return entity == null;
    }
}

public class Mapper<TSource, TDest>
    where TSource : class
    where TDest : class, new()
{
    public TDest Map(TSource source)
    {
        var dest = new TDest();
        // Copy properties...
        return dest;
    }
}
