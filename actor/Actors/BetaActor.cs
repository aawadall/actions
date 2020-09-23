using actor.Messages;
using Akka.Actor;
using Newtonsoft.Json;
using System;

namespace actor.Actors
{
    public class BetaActor : ReceiveActor
    {

        public BetaActor()
        {

            System.Console.WriteLine($"Creating a {this.GetType().Name}");
            Receive<SampleMessage>(HandleSampleMessage, message => message.Id == 0x10);
            Receive<SampleMessage>(DefaultMessageHandler);
        }

        public override void AroundPostRestart(Exception cause, object message)
        {
            base.AroundPostRestart(cause, message);
        }

        public override void AroundPostStop()
        {
            base.AroundPostStop();
        }

        public override void AroundPreRestart(Exception cause, object message)
        {
            base.AroundPreRestart(cause, message);
        }

        public override void AroundPreStart()
        {
            base.AroundPreStart();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override bool AroundReceive(Receive receive, object message)
        {
            return base.AroundReceive(receive, message);
        }

        protected override void PostRestart(Exception reason)
        {
            base.PostRestart(reason);
        }

        protected override void PostStop()
        {
            System.Console.WriteLine($"Actor [{this.GetType().Name}] PostStop");
            base.PostStop();
        }

        protected override void PreRestart(Exception reason, object message)
        {
            base.PreRestart(reason, message);
        }

        protected override void PreStart()
        {
            System.Console.WriteLine("Actor Starting");
            base.PreStart();
        }

        protected override SupervisorStrategy SupervisorStrategy()
        {
            return base.SupervisorStrategy();
        }

        protected override void Unhandled(object message)
        {
            base.Unhandled(message);
        }

        private void DefaultMessageHandler(SampleMessage obj)
        {
            System.Console.WriteLine($"Default message handler");
        }

        private void HandleSampleMessage(SampleMessage message) 
        {
            System.Console.WriteLine($"Recieved message:\n {JsonConvert.SerializeObject(message)}");
            
        }

        
    }
}