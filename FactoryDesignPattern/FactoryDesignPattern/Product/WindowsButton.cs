namespace FactoryDesignPattern.Product
{
    class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Windows Button is working..");
        }
    }
}