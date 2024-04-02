namespace Design_Pattern__Factory_method_.Model.Transport
{
    internal class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Ship: Deliver");
        }
    }
}
