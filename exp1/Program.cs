using System;
using actor;
using Akka.Actor;
namespace exp1
{
    class Program
    {
        private static ActorSystem SampleActorSystem;

        static void Main(string[] args)
        {
            SampleActorSystem = ActorSystem.Create("SampleActorSystem");
            System.Console.WriteLine("Actor system created");

            Props sampleActorProps = Props.Create<PrimitiveActor>();
            IActorRef actorRef = SampleActorSystem.ActorOf(sampleActorProps, "SampleActor");

            actorRef.Tell("Primitive String Message");
            actorRef.Tell(0x101);
            actorRef.Tell('c');
            Console.ReadLine();
            SampleActorSystem.Terminate();
        }
    }
}
