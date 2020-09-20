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
            Receive<SampleMessage>(message => HandleSampleMessage(message), message => message.Id == 0x10);
            Receive<SampleMessage>(DefaultMessageHandler);
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