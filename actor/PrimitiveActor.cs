
using System;
using actor.Messages;
using Akka.Actor;
namespace actor
{
    public class PrimitiveActor : UntypedActor
    {
        public PrimitiveActor()
        {
            System.Console.WriteLine("Creating a Primitive Actor");
        }
        

        protected override void OnReceive(object message)
        {
            if(message is SampleMessage)
            {
                System.Console.WriteLine($"Received message of type {message.GetType().Name}");
                System.Console.WriteLine($"With Id: {((SampleMessage)message).Id}");
                System.Console.WriteLine($"And Title: {((SampleMessage)message).Title}");
            }
            else 
            {
                Unhandled(message);
            }
        }       
    }
}