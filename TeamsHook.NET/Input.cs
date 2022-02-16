namespace TeamsHook.NET
{
    public abstract class Input
    {
        protected Input(MessageInputType type)
        {
            Type = type;
        }

        public string Id { get; set; }

        public bool IsRequired { get; set; }

        public string Title { get; set; }

        public MessageInputType Type { get; private set; }

        public string Value { get; set; }
    }
}