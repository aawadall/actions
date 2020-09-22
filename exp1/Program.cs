using System;
using System.Threading.Tasks;
using actor;
using actor.Actors;
using actor.Messages;
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

            Props sampleActorProps = Props.Create<BetaActor>();
            IActorRef actorRef = SampleActorSystem.ActorOf(sampleActorProps, "SampleActor");

            actorRef.Tell(new SampleMessage("sample title", 0x102));
            actorRef.Tell(new SampleMessage("sample title", 0x10));
            
            actorRef.Tell(PoisonPill.Instance);
            Console.ReadLine();
            SampleActorSystem.Terminate();
            Console.WriteLine("Waiting for Termination");
            SampleActorSystem.WhenTerminated.Wait();
            Console.WriteLine("Terminated");
            
        }
    }
}
