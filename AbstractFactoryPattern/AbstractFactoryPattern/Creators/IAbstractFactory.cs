using AbstractFactoryPattern.Products.Chair;
using AbstractFactoryPattern.Products.CoffeeTable;
using AbstractFactoryPattern.Products.Sofa;

namespace AbstractFactoryPattern.Creators
{
    public interface IAbstractFactory
    {
        IChair CreateChair();

        ISofa CreateSofa();
        ICoffeeTable CreateCoffeeTable();
    }
}