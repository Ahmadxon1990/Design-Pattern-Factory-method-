namespace Design_Pattern__Factory_method_.Model.Transport
{
    internal class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Truck: Deliver");
        }
    }
}
