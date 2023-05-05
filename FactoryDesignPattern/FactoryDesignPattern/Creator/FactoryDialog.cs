using FactoryDesignPattern.Product;

namespace FactoryDesignPattern.Creator
{

    abstract class FactoryDialog
    {
        public abstract IButton CreateButton();

    }
}