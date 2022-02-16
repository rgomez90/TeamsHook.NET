using System.Text.Json.Serialization;

namespace TeamsHook.NET
{
    public abstract class MessageAction
    {
        protected MessageAction(MessageActionType type)
        {
            Type = type;
        }

        public MessageActionType Type { get; private set; }
    }
}