namespace Assignment1.Variance;

public interface IConsumer<in T>
{
    void Consume(T item);
}

public class AnimalFeeder : IConsumer<Animal>
{
    public void Consume(Animal a)
    {
        Console.WriteLine("Feeding animal");
    }
}

public static class ContravarianceDemo
{
    public static void Run()
    {
        Action<Animal> feedAnimal = a => Console.WriteLine("Feed");
        Action<Dog> feedDog = feedAnimal;

        IConsumer<Animal> animalFeeder = new AnimalFeeder();
        IConsumer<Dog> dogFeeder = animalFeeder;

        dogFeeder.Consume(new Dog());
    }
}
