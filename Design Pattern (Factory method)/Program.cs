using Design_Pattern__Factory_method_.Service.CreateTransport;

namespace Design_Pattern__Factory_method_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogistics logistics = new RoadLogistics();
            logistics.CreateTransport().Deliver();
        }
    }
}
