using FactoryDesignPattern.Product;

namespace FactoryDesignPattern.Creator
{
    class WindowsDialogFactory : FactoryDialog
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}