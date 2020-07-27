using System;

namespace TeamsHook.NET
{
    public class InvokeAddInCommandAction : MessageAction
    {
        public InvokeAddInCommandAction(MessageActionType type) : base(MessageActionType.InvokeAddInCommand)
        {
        }

        public string DesktopCommandId { get; set; }
        public object InitializationContext { get; set; }
        public string Name { get; set; }
        public Guid Uuid { get; set; }
    }
}