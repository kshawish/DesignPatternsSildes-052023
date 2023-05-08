using AbstractFactoryPattern.Creators;

namespace AbstractFactoryPattern.Client
{

    class Client
    {
       
        public void RequestFirtiture(IAbstractFactory factory)
        {
            var chair = factory.CreateChair();
            var sofa = factory.CreateSofa();
            var coffeTable = factory.CreateCoffeeTable();

            Console.WriteLine(chair.UsefulFunctionA());
            Console.WriteLine(sofa.UsefulFunctionB());
            Console.WriteLine(coffeTable.UsefulFunctionC());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client is requesting modern firniture");
            var client1 = new Client();
            client1.RequestFirtiture(new ModernFactory());
            

            Console.WriteLine("Client is requesting Victorian firniture");
            var client2 = new Client();
            client2.RequestFirtiture(new VictorianFactory());
            Console.WriteLine("Done");

        }
    }
}