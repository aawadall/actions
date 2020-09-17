using System;
using actor;
namespace exp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Actor System!");

            var actSys = new ActorEcoSystem();

            Console.ReadLine();
        }
    }
}
