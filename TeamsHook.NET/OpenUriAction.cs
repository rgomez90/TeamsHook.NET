using System.Collections.Generic;

namespace TeamsHook.NET
{
    public class OpenUriAction : MessageAction
    {
        public OpenUriAction() : base(MessageActionType.OpenUri)
        {
        }

        public string Name { get; set; }
        public HashSet<Target> Targets { get; set; }
    }
}