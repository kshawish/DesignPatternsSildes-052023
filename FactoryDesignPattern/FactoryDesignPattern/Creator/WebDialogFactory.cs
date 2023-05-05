using FactoryDesignPattern.Product;

namespace FactoryDesignPattern.Creator
{
    class WebDialogFactory : FactoryDialog
    {
        public override IButton CreateButton()
        {
            return new HTMLButton();
        }
    }
}