using System.Collections.Generic;

namespace TeamsHook.NET
{
    public class ActionCard : MessageAction
    {
        public ActionCard() : base(MessageActionType.ActionCard)
        {
        }

        public IList<MessageAction> Actions { get; set; }
        public IList<Input> Inputs { get; set; }
        public string Name { get; set; }
    }
}