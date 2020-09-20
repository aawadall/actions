namespace actor.Messages
{
    public class SampleMessage
    {
        public string Title { get; private set; }
        public int Id { get; private set; }

        public SampleMessage(string title, int id)
        {
            Title = title;
            Id = id;
        }
    }
}