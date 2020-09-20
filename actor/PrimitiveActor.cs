
using System;
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
            if(message is string)
            {
                System.Console.WriteLine($"Received string message: {message}");
            }
            else if(message is int)
            {
                System.Console.WriteLine($"Received int message: {message}");
            }
            else 
            {
                Unhandled(message);
            }
        }

        
    }
}