namespace FactoryDesignPattern.Product
{
    class HTMLButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("HTML Button is working..");
        }
    }
}