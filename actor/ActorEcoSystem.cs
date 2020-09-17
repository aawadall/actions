using Akka.Actor;
using Akka.Actor.Internal;

namespace actor
{
    public class ActorEcoSystem
    {
        private static ActorSystem DefaultActorSystem;

        public ActorEcoSystem()
        {
            DefaultActorSystem = ActorSystem.Create("DefaultActorSystem");
        }
    }
}