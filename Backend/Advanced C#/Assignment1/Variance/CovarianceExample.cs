namespace Assignment1.Variance;

public class Animal { }
public class Dog : Animal { }

public interface IProducer<out T>
{
    T Produce();
}

public class DogProducer : IProducer<Dog>
{
    public Dog Produce() => new Dog();
}

public static class CovarianceDemo
{
    public static void Run()
    {
        IEnumerable<Dog> dogs = new List<Dog> { new Dog() };
        IEnumerable<Animal> animals = dogs;

        IProducer<Dog> dogProducer = new DogProducer();
        IProducer<Animal> animalProducer = dogProducer;
    }
}
