using System;

namespace Factory
{
    abstract class Product { }

    class ConcreteProductA : Product
    {
        public string GetType() { return "ConcreteProductA"; }
    }

    class ConcreteProductB : Product
    {
        public string GetType() { return "ConcreteProductB"; }
    }

    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductA(); }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductB(); }
    }

    public class MainApp
    {
        public static void Main()
        {
            // an array of creators
            Creator[] creators = { new ConcreteCreatorA(), new ConcreteCreatorB() };
            // iterate over creators and create products
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType());
            }
            // Wait for user
            Console.Read();
        }
    }
}