using AbstractFactoryPattern.Products.Chair;
using AbstractFactoryPattern.Products.CoffeeTable;
using AbstractFactoryPattern.Products.Sofa;

namespace AbstractFactoryPattern.Creators
{
    class VictorianFactory : IAbstractFactory
    {

        IChair IAbstractFactory.CreateChair()
        {
            return new VictorianChair();
        }

        ISofa IAbstractFactory.CreateSofa()
        {
            return new VictorianSofa();
        }

        ICoffeeTable IAbstractFactory.CreateCoffeeTable()
        {
            return new VictorianCoffeTable();
        }
    }
}