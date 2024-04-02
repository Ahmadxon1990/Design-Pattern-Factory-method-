﻿using Design_Pattern__Factory_method_.Model;
using Design_Pattern__Factory_method_.Model.Transport;
using Design_Pattern__Factory_method_.Service.CreateTransport;

namespace Design_Pattern__Factory_method_.Service.CreateTransport
{
    internal class RoadLogistics : ILogistics
    {
        private ITransport transport { get; set; }
        public ITransport CreateTransport()
        {
            return new Truck();
        }

        public void PlanDeliver()
        {
            this.transport = CreateTransport();
        }
    }
}