namespace Assignment1.Interfaces;

public interface IRepository<T> where T : class
{
    T? GetById(int id);
    IEnumerable<T> GetAll();
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
    bool Exists(int id);
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}

public class UserRepository : IRepository<User>
{
    private readonly List<User> users = new();

    public User? GetById(int id)
    {
        return users.FirstOrDefault(u => u.Id == id);
    }

    public IEnumerable<User> GetAll()
    {
        return users;
    }

    public void Add(User entity)
    {
        users.Add(entity);
    }

    public void Update(User entity)
    {
        var existing = GetById(entity.Id);
        if (existing != null)
        {
            var index = users.IndexOf(existing);
            users[index] = entity;
        }
    }

    public void Delete(int id)
    {
        var user = GetById(id);
        if (user != null)
            users.Remove(user);
    }

    public bool Exists(int id)
    {
        return GetById(id) != null;
    }
}
