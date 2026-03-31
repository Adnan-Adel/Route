namespace Assignment1.Constraints;

public abstract class Entity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public abstract void Validate();
}

public class EntityRepository<T> where T : Entity
{
    private List<T> entities = new();
    private int nextId = 1;

    public void Add(T entity)
    {
        entity.Validate();
        entity.Id = nextId++;
        entities.Add(entity);
    }

    public T? GetById(int id)
    {
        return entities.FirstOrDefault(e => e.Id == id);
    }

    public IEnumerable<T> GetRecent(int days)
    {
        DateTime cutoff = DateTime.Now.AddDays(-days);
        return entities.Where(e => e.CreatedAt >= cutoff);
    }
}

public class UserEntity : Entity
{
    public string Name { get; set; } = "";

    public override void Validate()
    {
        if (string.IsNullOrEmpty(Name))
            throw new Exception("Name required");
    }
}
