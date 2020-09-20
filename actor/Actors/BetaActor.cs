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
            Receive<SampleMessage>(message => HandleSampleMessage(message));
        }

        private void HandleSampleMessage(SampleMessage message) 
        {
            System.Console.WriteLine($"Recieved message:\n {JsonConvert.SerializeObject(message)}");
        }
    }
}