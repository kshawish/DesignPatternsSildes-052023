using AbstractFactoryPattern.Products.Chair;
using AbstractFactoryPattern.Products.CoffeeTable;
using AbstractFactoryPattern.Products.Sofa;

namespace AbstractFactoryPattern.Creators
{
    class ArtFactory : IAbstractFactory
    {

        IChair IAbstractFactory.CreateChair()
        {
            return new ArtChair();
        }

        ISofa IAbstractFactory.CreateSofa()
        {
            return new ArtSofa();
        }

        ICoffeeTable IAbstractFactory.CreateCoffeeTable()
        {
            return new ArtCoffeTable();
        }
    }
}