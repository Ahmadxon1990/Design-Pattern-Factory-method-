using Design_Pattern__Factory_method_.Model;

namespace Design_Pattern__Factory_method_.Service.CreateTransport
{
    internal interface ILogistics
    {
       
        void PlanDeliver();

        ITransport CreateTransport();
       
    }
}
