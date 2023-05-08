using AbstractFactoryPattern.Products.Chair;
using AbstractFactoryPattern.Products.CoffeeTable;
using AbstractFactoryPattern.Products.Sofa;

namespace AbstractFactoryPattern.Creators
{
    class ModernFactory : IAbstractFactory
    {

        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {

            return new ModernSofa();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeTable();
        }
    }
}